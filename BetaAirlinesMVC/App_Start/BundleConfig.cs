﻿using System.Web;
using System.Web.Optimization;

namespace BetaAirlinesMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                       "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                       "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                       "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/css/Reset.css",
                       "~/Content/bootstrap.css",
                       "~/Content/css/Main.css",
                       "~/Content/css/FontAwesome5all.css"));

            bundles.Add(new ScriptBundle("~/bundles/myScripts").Include(
                       "~/Scripts/js/Utilities.js"));
        }
    }
}
