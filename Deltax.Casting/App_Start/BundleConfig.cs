using System.Web;
using System.Web.Optimization;

namespace Deltax.Casting
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //newly added
            bundles.Add(new StyleBundle("~/Content/custom").Include(
                "~/Content/assets/libs/chartist/dist/chartist.min.css",
                "~/Content/dist/css/style.min.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jquerymin").Include(
                       "~/Content/assets/libs/jquery/dist/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapteather").Include(
                    "~/Content/assets/libs/popper.js/dist/umd/popper.min.js",
                    "~/Content/assets/libs/bootstrap/dist/js/bootstrap.min.js",
                    "~/Content/dist/js/waves.js",
                    "~/Content/dist/js/sidebarmenu.js",
                    "~/Content/dist/js/custom.min.js"));
        }
    }
}
