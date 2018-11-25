using System.Web;
using System.Web.Optimization;

namespace Solentive.Interview.WebUI
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/appscripts").Include("~/appScriptsJS/*.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include("~/Scripts/jquery-ui-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/validation").Include("~/Scripts/jquery.unobtrusive*","~/Scripts/jquery.validate*"));
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/custom").Include("~/Content/custom.css","~/Content/custom-bootstrap.css"));
        }
    }
}