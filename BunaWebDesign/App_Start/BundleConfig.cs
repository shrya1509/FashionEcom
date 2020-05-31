using System.Web;
using System.Web.Optimization;

namespace BunaWebDesign
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //To add Jquery in project
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-3.5.1.slim.min.js"));

            //To add Bootstrap JS
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Scripts/bootstrap.bundle.js","~/Scripts/popper.min.js"));


            //To add Bootstrap CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/CSS/carousel.css",
                     "~/CSS/bootstrap.css"));
           
        }
    }
}