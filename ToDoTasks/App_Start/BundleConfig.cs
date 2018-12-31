using System.Web;
using System.Web.Optimization;

namespace ToDoTasks
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/Home").Include(
                    "~/Scripts/Home/HomePage.js"));

            bundles.Add(new ScriptBundle("~/bundles/ToolTip").Include(
                    "~/Scripts/jquery.qtip.js"));

            bundles.Add(new ScriptBundle("~/bundles/ToolTipCSS").Include(
                    "~/Scripts/jquery.qtip.css.js"));
        }
    }
}
