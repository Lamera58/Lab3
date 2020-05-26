using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Vix
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
            "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/op/css").Include(
            "~/Content/open-iconic-bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/mp/css").Include(
            "~/Content/magnific-popup.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/jqt/css").Include(
            "~/Content/jquery.timepicker.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/iconc/css").Include(
            "~/Content/ionicons.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/iconm/css").Include(
            "~/Content/icomoon.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/flat/css").Include(
            "~/Content/flaticon.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bm/css").Include(
            "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/aos/css").Include(
            "~/Content/aos.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bmd/css").Include(
            "~/Content/bootstrap-datepicker.css", new CssRewriteUrlTransform()));          
            bundles.Add(new StyleBundle("~/bundles/owlc/css").Include(
            "~/Content/owl.carousel.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/owlt/css").Include(
            "~/Content/owl.theme.default.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/style/css").Include(
            "~/Content/style.css", new CssRewriteUrlTransform()));







            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
            "~/Scripts/jquery-3.2.1.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/popper/js").Include(
            "~/Scripts/popper.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
            "~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/scrollax/js").Include(
            "~/Scripts/scrollax.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/sowl/js").Include(
          "~/Scripts/owl.carousel.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
          "~/Scripts/main.js"));
            bundles.Add(new ScriptBundle("~/bundles/ais/js").Include(
          "~/Scripts/aos.js"));

        }
    }
}