using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Movie_Ticket.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                   //<!-- Bootstrap -->
                   .Include("~/Areas/admin/Content/vendors/bootstrap/dist/css/bootstrap.min.css")
                   //<!-- Font Awesome -->
                   .Include("~/Areas/admin/Content/vendors/font-awesome/css/font-awesome.min.css")
                   //<!-- NProgress -->
                   .Include("~/Areas/admin/Content/vendors/vendors/nprogress/nprogress.css")
                   //<!-- iCheck -->
                   .Include("~/Areas/admin/Content/vendors/iCheck/skins/flat/green.css")
                   //<!-- bootstrap-progressbar -->
                   .Include("~/Areas/admin/Content/vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css")
                   //<!-- JQVMap -->
                   //<!-- bootstrap-daterangepicker -->
                   .Include("~/Areas/admin/Content/vendors/bootstrap-daterangepicker/daterangepicker.css")
                   //<!-- Custom Theme Style -->
                   .Include("~/Areas/admin/Content/build/css/custom.min.css")

                   );

            bundles.Add(new ScriptBundle("~/admin/scripts")
                //<!--jQuery-->
                .Include("~/Areas/admin/Content/vendors/jquery/dist/jquery.min.js")
                //<!--Bootstrap-->
                .Include("~/Areas/admin/Content/vendors/bootstrap/dist/js/bootstrap.min.js")
                //<!-- FastClick -->
                .Include("~/Areas/admin/Content/vendors/fastclick/lib/fastclick.js")
                //<!-- NProgress -->
                .Include("~/Areas/admin/Content/vendors/nprogress/nprogress.js")
                //<!-- Chart.js -->
                .Include("~/Areas/admin/Content/vendors/Chart.js/dist/Chart.min.js")
                //<!-- gauge.js -->
                .Include("~/Areas/admin/Content/vendors/gauge.js/dist/gauge.min.js")
                //<!-- bootstrap-progressbar -->
                .Include("~/Areas/admin/Content/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js")
                //<!-- iCheck -->
                // <!-- Skycons -->
                //<!-- Flot -->
                //<!-- Flot plugins -->
                // <!-- DateJS -->
                .Include("~/Areas/admin/Content/vendors/DateJS/build/date.js")
                //<!-- JQVMap -->
                //<!-- bootstrap-daterangepicker -->
                .Include("~/Areas/admin/Content/vendors/moment/min/moment.min.js")
                .Include("~/Areas/admin/Content/vendors/bootstrap-daterangepicker/daterangepicker.js")
                //<!-- Custom Theme Scripts -->
                .Include("~/Areas/admin/Content/build/js/custom.min.js")

                );
        }


    }
}