﻿
using Microsoft.AspNet.Mvc.Rendering;
using System;
using Microsoft.AspNet.Mvc.ViewFeatures;

namespace GenFu.Web.Helpers
{
    public static class ViewHelpers
    {
        public static string IsActive(this HtmlHelper helper, string controller, string action)
        {
            // grab route data from the view context
            var route = helper.ViewContext.RouteData;

            // figure out if up is up and left isn't right
            var isCurrentAction = route.Values["action"].ToString() == action;
            var isCurrentController = route.Values["controller"].ToString() == controller;
            var isActive = (isCurrentController && isCurrentAction);

            // we'll use this as a nullable attribute value in the view
            return isActive ? "active" : "";
        }
    }
}