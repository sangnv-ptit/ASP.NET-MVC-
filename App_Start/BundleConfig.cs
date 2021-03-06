using System.Web;
using System.Web.Optimization;

namespace WebApplication1
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
                      "~/Scripts/bootstrap.bundle.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/customscript").Include(
                    "~/Scripts/popper.min.js",
                    "~/Scripts/jquery.superslides.min.js",
                    "~/Scripts/bootstrap-select.js",
                    "~/Scripts/inewsticker.js",
                    "~/Scripts/bootsnav.js",
                    "~/Scripts/images-loded.min.js",
                    "~/Scripts/isotope.min.js",
                    "~/Scripts/owl.carousel.min.js",
                    "~/Scripts/baguetteBox.min.js",
                    "~/Scripts/form-validator.min.js",
                    "~/Scripts/contact-form-script.js",
                    "~/Scripts/custom.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/style.css",
                      "~/Content/responsive.css",
                      "~/Content/custom.css"));

            //Admin
            bundles.Add(new ScriptBundle("~/adminlte/js").Include(
             "~/adminlte/js/adminlte.min.js"));

            bundles.Add(new StyleBundle("~/adminlte/css").Include(
                      //"~/Content/bootstrap.css",
                      "~/adminlte/plugins/fontawesome-free/css/all.min.css",
                      "~/adminlte/css/adminlte.min.css",
                      "~/Content/site.css"));
        }
    }
}
