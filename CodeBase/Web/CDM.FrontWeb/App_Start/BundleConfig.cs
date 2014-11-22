using System.Web;
using System.Web.Optimization;

namespace CDM.FrontWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
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
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular/services").Include(
                      "~/Scripts/services/authService.js",
                        "~/Scripts/services/authInterceptorService.js"));
            bundles.Add(new Bundle("~/bundles/files/scripts")
              .Include("~/Scripts/jquery-{version}.js")
              .Include("~/Scripts/bootstrap.js")
              .Include("~/Scripts/angular.js"));
    

            bundles.Add(new ScriptBundle("~/bundles/angular/controllers").Include(
                "~/Scripts/controllers/loginController.js",
                  "~/Scripts/controllers/indexController.js"));

             bundles.Add(new ScriptBundle("~/bundles/others").Include(
                "~/Content/js/jquery-1.11.1.min.js",
                    "~/Content/js/jquery.noconflict.js",
                        "~/Content/js/modernizr.2.7.1.min.js",
                            "~/Content/js/jquery-migrate-1.2.1.min.js",
                                "~/Content/js/jquery.placeholder.js",
                                    "~/Content/js/jquery-ui.1.10.4.min.js"
                                    ));





             bundles.Add(new ScriptBundle("~/bundles/files/amplify").Include(
         
             "~/Scripts/amplify.js",

              "~/Scripts/amplify/amplify.core.js",

               "~/Scripts/amplify/amplify.store.js"));


            bundles.Add(new ScriptBundle("~/bundles/files/externals").Include(
           "~/Scripts/angular-local-storage.js",
              "~/Scripts/loading-bar.js",
            "~/Scripts/toastr.js"
           
          ));

            bundles.Add(new ScriptBundle("~/bundles/loadpageJavascript").Include(
             "~/Content/js/theme-scripts.js",
              "~/Content/js/scripts.js"
              ));


            bundles.Add(new ScriptBundle("~/bundles/parallax").Include(

           "~/Content/js/jquery.stellar.min.js"
           ));

               bundles.Add(new ScriptBundle("~/bundles/loadrevolution").Include(

           "~/Content/components/revolution_slider/js/jquery.themepunch.plugins.min.js",
           "~/Content/components/revolution_slider/js/jquery.themepunch.revolution.min.js"
           ));

                  bundles.Add(new ScriptBundle("~/bundles/BXSlider").Include(

           "~/Content/components/jquery.bxslider/jquery.bxslider.min.js",
           "~/Content/components/flexslider/jquery.flexslider.js"
           ));




            bundles.Add(new ScriptBundle("~/bundles/waypoint").Include(

           "~/Content/js/waypoints.min.js"
           ));

            bundles.Add(new ScriptBundle("~/bundles/angular/modules").Include(
               "~/Scripts/modules/amplifyService.js",
                "~/Scripts/app.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                 "~/Scripts/angular.js",
             "~/Scripts/angular-route.js"


             
              ));



            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
