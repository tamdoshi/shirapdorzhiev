using System.Web;
using System.Web.Optimization;

namespace Shirapdorzhiev
{
    public class BundleConfig
    {
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/cycle").Include(

                        "~/Scripts/insic.js", "~/Scripts/jquery.cycle.all.js"));

            bundles.Add(new ScriptBundle("~/bundles/glisse").Include(

                        "~/Scripts/glisse.js", "~/Scripts/glissecall.js"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // используйте средство сборки на сайте http://modernizr.com, чтобы выбрать только нужные тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/style.css",
                      "~/Content/reset.css"

                      ));

            bundles.Add(new StyleBundle("~/Content/glisse").Include(
                     "~/Content/glisse.css"
                      ));
        }
    }
}
