using System.Web;
using System.Web.Optimization;

namespace MeetingCoordinator
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/plugins/bootstrapv3/css/bootstrap.min.css",
                      "~/Scripts/plugins/bootstrapv3/css/bootstrap-theme.min.css"));

            bundles.Add(new StyleBundle("~/bundles/theme").Include(
                      "~/Scripts/plugins/pace/pace-theme-flash.css",
                      "~/Scripts/plugins/jquery-scrollbar/jquery.scrollbar.css",
                      "~/Scripts/plugins/font-awesome/css/font-awesome.css",
                      "~/Scripts/css/animate.min.css",
                      "~/Scripts/css/style.css",
                      "~/Scripts/css/responsive.css",
                      "~/Scripts/css/custom-icon-set.css"));

            bundles.Add(new ScriptBundle("~/bundles/javascript").Include(
                      "~/Scripts/plugins/jquery-1.8.3.min.js",
                      "~/Scripts/plugins/jquery-ui/jquery-ui-1.10.1.custom.min.js",
                      "~/Scripts/plugins/bootstrapv3/js/bootstrap.min.js",
                      "~/Scripts/plugins/breakpoints.js",
                      "~/Scripts/plugins/jquery-unveil/jquery.unveil.min.js",
                      "~/Scripts/plugins/jquery-block-ui/jqueryblockui.js",
                      "~/Scripts/plugins/jquery-scrollbar.min.js",
                      "~/Scripts/plugins/pace/pace.min.js",
                      "~/Scripts/plugins/jquery-numberAnimate/jquery.animateNumbers.js"));
        }
    }
}
