﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Ilaro.Admin.Core;
using Ilaro.Admin.Extensions;
using Resources;

namespace Ilaro.Admin.Filters
{
    public class DateTimeEntityFilter : BaseFilter<DateTime>
    {
        public override Property Property { get; protected set; }
        public override sealed SelectList Options { get; protected set; }
        public override sealed string Value { get; protected set; }
        public override bool DisplayInUi { get { return true; } }

        public DateTimeEntityFilter(IKnowTheTime clock, Property property, string value = "")
            : base(property, value)
        {
            if (clock == null)
                throw new ArgumentNullException("clock");

            var now = clock.Now;
            var options = new Dictionary<string, string>
            {
                { IlaroAdminResources.All, String.Empty },
                { IlaroAdminResources.Today, now.ToString("yyyy.MM.dd") },
                { IlaroAdminResources.Yesterday, now.AddDays(-1).ToString("yyyy.MM.dd") },
                { IlaroAdminResources.LastWeek, now.AddDays(-7).ToString("yyyy.MM.dd") + "-" + now.ToString("yyyy.MM.dd") },
                { IlaroAdminResources.LastMonth, now.AddMonths(-1).ToString("yyyy.MM.dd") + "-" + now.ToString("yyyy.MM.dd") },
                { IlaroAdminResources.LastQuarter, now.AddMonths(-3).ToString("yyyy.MM.dd") + "-" + now.ToString("yyyy.MM.dd") },
                { IlaroAdminResources.LastHalfAYear, now.AddMonths(-6).ToString("yyyy.MM.dd") + "-" + now.ToString("yyyy.MM.dd") },
                { IlaroAdminResources.LastYear, now.AddYears(-1).ToString("yyyy.MM.dd") + "-" + now.ToString("yyyy.MM.dd") }
            };

            Options = new SelectList(options, "Value", "Key", Value);
        }

        public override string GetSqlCondition(string alias, ref List<object> args)
        {
            if (Value.Contains('-') == false)
            {
                var sql = "({0}{1} >= @{2} AND {0}{1} <= @{3})".Fill(alias, Property.ColumnName, args.Count, args.Count + 1);
                args.Add(Value + " 00:00");
                args.Add(Value + " 23:59");
                return sql;
            }

            var dates = Value.Split('-');

            if (dates.Length != 2)
                return null;

            if (dates[0].IsNullOrEmpty() == false && dates[1].IsNullOrEmpty() == false)
            {
                var sql = "({0}{1} >= @{2} AND {0}{1} <= @{3})".Fill(alias, Property.ColumnName, args.Count, args.Count + 1);
                args.Add(dates[0] + " 00:00");
                args.Add(dates[1] + " 23:59");
                return sql;
            }
            if (dates[0].IsNullOrEmpty() && dates[1].IsNullOrEmpty() == false)
            {
                var sql = "{0}{1} <= @{2}".Fill(alias, Property.ColumnName, args.Count);
                args.Add(dates[1] + " 23:59");
                return sql;
            }
            if (dates[0].IsNullOrEmpty() == false && dates[1].IsNullOrEmpty())
            {
                var sql = "{0}{1} >= @{2}".Fill(alias, Property.ColumnName, args.Count);
                args.Add(dates[0] + " 00:00");
                return sql;
            }

            return null;
        }
    }
}