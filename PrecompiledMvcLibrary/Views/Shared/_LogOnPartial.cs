﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrecompiledMvcLibrary.Views.Shared
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;
    
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_LogOnPartial.cshtml")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorSingleFileGenerator", "0.6.0.0")]
    public class _Page_Views_Shared__LogOnPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
#line hidden

        public _Page_Views_Shared__LogOnPartial_cshtml()
        {
        }
        protected System.Web.HttpApplication ApplicationInstance
        {
            get
            {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        public override void Execute()
        {


WriteLiteral("\r\n");


 if(Request.IsAuthenticated) {

WriteLiteral("    ");

WriteLiteral("Welcome <b>");


                Write(Context.User.Identity.Name);

WriteLiteral("</b>!\r\n    [ ");


 Write(Html.ActionLink("Log Off", "LogOff", "Account"));

WriteLiteral(" ]");

WriteLiteral("\r\n");


}
else {

WriteLiteral("    ");

WriteLiteral("[ ");


   Write(Html.ActionLink("Log On", "LogOn", "Account"));

WriteLiteral(" ]\r\n");


}


        }
    }
}
#pragma warning restore 1591
