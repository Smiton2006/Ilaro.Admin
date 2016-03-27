﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin;
    using Ilaro.Admin.Core;
    using Ilaro.Admin.Core.Extensions;
    using Ilaro.Admin.Extensions;
    using Ilaro.Admin.Models;
    using Ilaro.Admin.Models.Paging;
    using Resources;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/IlaroAdmin/Views/Entities/Index.cshtml")]
    public partial class _Areas_IlaroAdmin_Views_Entities_Index_cshtml : System.Web.Mvc.WebViewPage<EntitiesIndexModel>
    {
        public _Areas_IlaroAdmin_Views_Entities_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
  
    Layout = "~/Areas/IlaroAdmin/Views/Shared/_Layout.cshtml";
    ViewBag.Title = Model.Entity.Verbose.Plural;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("Breadcrumb", () => {

WriteLiteral("\r\n    <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n        <li>");

            
            #line 11 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
       Write(Html.ActionLink(IlaroAdminResources.Index_Title, "Index", "Group", new { area = "IlaroAdmin" }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 12 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
       Write(Html.ActionLink(Model.Entity.Verbose.Group, "Details", "Group", new { area = "IlaroAdmin", groupName = Model.Entity.Verbose.Group }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">");

            
            #line 13 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                      Write(Model.Entity.Verbose.Plural);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n    <h2");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">");

            
            #line 18 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                     Write(Model.Entity.Verbose.Plural);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

            
            #line 19 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
     if (Model.Entity.IsSearchActive)
    {
        using (Html.BeginForm("Index", "Entities", new { area = "IlaroAdmin", page = Model.Pager.Current }, FormMethod.Get, new { @class = "pull-left col-md-3" }))
        {
            foreach (var filter in Model.ActiveFilters)
            {
                
            
            #line default
            #line hidden
            
            #line 25 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
           Write(Html.Hidden(filter.Property.Name, filter.Value));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                
            }
            
            
            #line default
            #line hidden
            
            #line 27 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
       Write(Html.Hidden("entityName", Model.Entity.Name));

            
            #line default
            #line hidden
            
            #line 27 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                         
            
            
            #line default
            #line hidden
            
            #line 28 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
       Write(Html.Hidden(Model.Configuration.PerPageRequestName, Model.TableInfo.PerPage));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                         
            
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
       Write(Html.Hidden(Model.Configuration.OrderRequestName, Model.TableInfo.Order));

            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                     
            
            
            #line default
            #line hidden
            
            #line 30 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
       Write(Html.Hidden(Model.Configuration.OrderDirectionRequestName, Model.TableInfo.OrderDirection));

            
            #line default
            #line hidden
            
            #line 30 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                                       

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 32 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
           Write(Html.TextBox(Model.Configuration.SearchQueryRequestName, Model.TableInfo.SearchQuery, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <span");

WriteLiteral(" class=\"input-group-btn\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">");

            
            #line 34 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                             Write(IlaroAdminResources.Search);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                </span>\r\n            </div>\r\n");

            
            #line 37 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 40 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
Write(Html.ActionLink(IlaroAdminResources.Changes, "Changes", new { entityName = Model.Entity.Name }, new { @class = "btn btn-link pull-left" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 42 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
     if (Model.Entity.AllowAdd)
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1952), Tuple.Create("\"", 2051)
            
            #line 44 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1959), Tuple.Create<System.Object, System.Int32>(Url.Action("Create", "Entity", new { area = "IlaroAdmin", entityName = Model.Entity.Name })
            
            #line default
            #line hidden
, 1959), false)
);

WriteLiteral(" class=\"btn btn-primary pull-right\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-plus\"");

WriteLiteral("></span> ");

            
            #line 44 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                                                                                                                            Write(IlaroAdminResources.Add);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 45 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n<div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(" style=\"margin-bottom:10px\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"btn-group btn-group-sm pull-right\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" class=\"btn btn-default active\"");

WriteLiteral(" id=\"make-table-large\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-th-large\"");

WriteLiteral("></span></button>\r\n        <button");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" id=\"make-table-condensed\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-th\"");

WriteLiteral("></span></button>\r\n    </div>\r\n</div>\r\n\r\n<table");

WriteLiteral(" id=\"table-entity\"");

WriteLiteral(" class=\"table table-striped table-bordered table-hover\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n            ");

WriteLiteral("\r\n");

            
            #line 59 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 59 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
             foreach (var column in Model.Columns)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th>\r\n                    <span ");

            
            #line 62 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                     Write(Html.Condition(!string.IsNullOrEmpty(column.Description), () => "title=\"" + column.Description + "\""));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 63 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                   Write(Html.SortColumnLink(Model.Entity, column, Model.Filters, Model.TableInfo.SearchQuery, Model.TableInfo.PerPage));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <i");

WriteAttribute("class", Tuple.Create(" class=\"", 3138), Tuple.Create("\"", 3195)
, Tuple.Create(Tuple.Create("", 3146), Tuple.Create("glyphicon", 3146), true)
, Tuple.Create(Tuple.Create(" ", 3155), Tuple.Create("glyphicon-chevron-", 3156), true)
            
            #line 64 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
, Tuple.Create(Tuple.Create("", 3174), Tuple.Create<System.Object, System.Int32>(column.SortDirection
            
            #line default
            #line hidden
, 3174), false)
);

WriteLiteral("></i>\r\n                    </span>\r\n                </th>\r\n");

            
            #line 67 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 68 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
             if (Model.Entity.LinksCount() > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 3353), Tuple.Create("\"", 3389)
            
            #line 70 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
, Tuple.Create(Tuple.Create("", 3363), Tuple.Create<System.Object, System.Int32>(Model.Entity.LinksCount()
            
            #line default
            #line hidden
, 3363), false)
);

WriteLiteral("></th>\r\n");

            
            #line 71 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 75 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 75 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
         foreach (var row in Model.Data)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                ");

WriteLiteral("\r\n");

            
            #line 79 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 79 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                 foreach (var item in row.Values)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td>");

            
            #line 81 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                   Write(Html.DisplayFor(m => item, item.Property.Template.Display));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 82 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 83 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                 if (!Model.Entity.Links.Display.IsNullOrEmpty())
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"min-width\"");

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3938), Tuple.Create("\"", 4007)
            
            #line 86 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
, Tuple.Create(Tuple.Create("", 3945), Tuple.Create<System.Object, System.Int32>(string.Format(Model.Entity.Links.Display, row.JoinedKeyValue)
            
            #line default
            #line hidden
, 3945), false)
);

WriteLiteral(" class=\"btn btn-xs btn-link\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-eye-open\"");

WriteLiteral("></span> ");

            
            #line 86 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                                                                                                           Write(IlaroAdminResources.View);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </td>\r\n");

            
            #line 88 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 89 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                 if (Model.Entity.AllowEdit)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"min-width\"");

WriteLiteral(">\r\n");

            
            #line 92 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 92 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                         if (!Model.Entity.Links.Edit.IsNullOrEmpty())
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4402), Tuple.Create("\"", 4468)
            
            #line 94 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
, Tuple.Create(Tuple.Create("", 4409), Tuple.Create<System.Object, System.Int32>(string.Format(Model.Entity.Links.Edit, row.JoinedKeyValue)
            
            #line default
            #line hidden
, 4409), false)
);

WriteLiteral(" class=\"btn btn-xs btn-link\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-edit\"");

WriteLiteral("></span> ");

            
            #line 94 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                                                                                                        Write(IlaroAdminResources.Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 95 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4690), Tuple.Create("\"", 4813)
            
            #line 98 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
, Tuple.Create(Tuple.Create("", 4697), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit", "Entity", new { area = "IlaroAdmin", entityName = Model.Entity.Name, key = row.JoinedKeyValue })
            
            #line default
            #line hidden
, 4697), false)
);

WriteLiteral(" class=\"btn btn-xs btn-link\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-edit\"");

WriteLiteral("></span> ");

            
            #line 98 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                                                                                                                                                                 Write(IlaroAdminResources.Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 99 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n");

            
            #line 101 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 102 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                 if (Model.Entity.AllowDelete)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"min-width\"");

WriteLiteral(">\r\n");

            
            #line 105 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 105 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                         if (!Model.Entity.Links.Delete.IsNullOrEmpty())
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5234), Tuple.Create("\"", 5302)
            
            #line 107 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
, Tuple.Create(Tuple.Create("", 5241), Tuple.Create<System.Object, System.Int32>(string.Format(Model.Entity.Links.Delete, row.JoinedKeyValue)
            
            #line default
            #line hidden
, 5241), false)
);

WriteLiteral(" class=\"btn btn-xs btn-link text-danger\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral("></span> ");

            
            #line 107 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                                                                                                                        Write(IlaroAdminResources.Delete);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 108 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5540), Tuple.Create("\"", 5665)
            
            #line 111 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
, Tuple.Create(Tuple.Create("", 5547), Tuple.Create<System.Object, System.Int32>(Url.Action("Delete", "Entity", new { area = "IlaroAdmin", entityName = Model.Entity.Name, key = row.JoinedKeyValue })
            
            #line default
            #line hidden
, 5547), false)
);

WriteLiteral(" class=\"btn btn-xs btn-link text-danger\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral("></span> ");

            
            #line 111 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                                                                                                                                                                                 Write(IlaroAdminResources.Delete);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 112 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n");

            
            #line 114 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 116 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(" style=\"margin-right:10px\"");

WriteLiteral(">\r\n");

            
            #line 122 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 122 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
         using (Html.BeginForm("Index", "Entities", new { area = "IlaroAdmin", page = Model.Pager.Current }, FormMethod.Get, new { @class = "form-inline" }))
        {
            foreach (var filter in Model.ActiveFilters)
            {
                
            
            #line default
            #line hidden
            
            #line 126 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
           Write(Html.Hidden(filter.Property.Name, filter.Value));

            
            #line default
            #line hidden
            
            #line 126 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                
            }
            
            
            #line default
            #line hidden
            
            #line 128 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
       Write(Html.Hidden("entityName", Model.Entity.Name));

            
            #line default
            #line hidden
            
            #line 128 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                         
            
            
            #line default
            #line hidden
            
            #line 129 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
       Write(Html.Hidden(Model.Configuration.SearchQueryRequestName, Model.TableInfo.SearchQuery));

            
            #line default
            #line hidden
            
            #line 129 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                                 
            
            
            #line default
            #line hidden
            
            #line 130 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
       Write(Html.Hidden(Model.Configuration.OrderRequestName, Model.TableInfo.Order));

            
            #line default
            #line hidden
            
            #line 130 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                     
            
            
            #line default
            #line hidden
            
            #line 131 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
       Write(Html.Hidden(Model.Configuration.OrderDirectionRequestName, Model.TableInfo.OrderDirection));

            
            #line default
            #line hidden
            
            #line 131 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                                       

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 6730), Tuple.Create("\"", 6775)
            
            #line 133 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
, Tuple.Create(Tuple.Create("", 6736), Tuple.Create<System.Object, System.Int32>(Model.Configuration.PerPageRequestName
            
            #line default
            #line hidden
, 6736), false)
);

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 133 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                      Write(IlaroAdminResources.OnPage);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n");

WriteLiteral("                ");

            
            #line 134 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
           Write(Html.DropDownList(Model.Configuration.PerPageRequestName,
                 new SelectList(new Dictionary<int, int> { { 5, 5 }, { 10, 10 }, { 15, 15 }, { 20, 20 }, { 25, 25 }, { 50, 50 }, { 100, 100 } }, "Key", "Value", Model.TableInfo.PerPage),
                 new Dictionary<string, object> { { "class", "autoPostBack form-control" }, { "id", "per-page-entity" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 138 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(" style=\"margin-right:10px\"");

WriteLiteral(">\r\n");

            
            #line 142 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 142 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
          Html.RenderPartial("_Paging", Model.Pager);
            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(" style=\"line-height:29px\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 146 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
   Write(IlaroAdminResources.Founded);

            
            #line default
            #line hidden
WriteLiteral(" <strong>");

            
            #line 146 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                        Write(Model.Pager.TotalItems);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n    </div>\r\n</div>\r\n\r\n");

DefineSection("Sidebar", () => {

WriteLiteral("\r\n");

            
            #line 152 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 152 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
     if (Model.Filters.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h2>");

            
            #line 154 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
       Write(IlaroAdminResources.Filters);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

WriteLiteral("        <ul");

WriteLiteral(" class=\"nav nav-list\"");

WriteLiteral(">\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 7712), Tuple.Create("\"", 7840)
            
            #line 156 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
, Tuple.Create(Tuple.Create("", 7719), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Entities", new { area = "IlaroAdmin", entityName = Model.Entity.Name, page = Model.Pager.Current })
            
            #line default
            #line hidden
, 7719), false)
);

WriteLiteral(">");

            
            #line 156 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
                                                                                                                                               Write(IlaroAdminResources.RemoveFilters);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 157 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 157 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
             foreach (var filter in Model.Filters)
            {
                Html.RenderPartial("_Filter", filter);
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");

            
            #line 162 "..\..\Areas\IlaroAdmin\Views\Entities\Index.cshtml"
    }

            
            #line default
            #line hidden
});

WriteLiteral("\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $().ready(function () {
            $('table th #check-all').click(function () {
                var $this = $(this);
                var isChecked = $this.prop('checked');
                $this.parents('table').find('.row-checkbox').prop('checked', isChecked);
            });
            $('table tr').click(function () {
                var $this = $(this);
                var $checkbox = $this.find('.row-checkbox');
                //$checkbox.prop('checked', !$checkbox.prop('checked'));
            });
            $('#make-table-large').click(function () {
                var $this = $(this).addClass('active').siblings().removeClass('active');
                $('#table-entity').removeClass('table-condensed');
                $('#pagination-entity').removeClass('pagination-sm');
                $('#per-page-entity').removeClass('select-sm');
            });
            $('#make-table-condensed').click(function () {
                var $this = $(this).addClass('active').siblings().removeClass('active');
                $('#table-entity').addClass('table-condensed');
                $('#pagination-entity').addClass('pagination-sm');
                $('#per-page-entity').addClass('select-sm');
            });
        });
    </script>
");

});

        }
    }
}
#pragma warning restore 1591
