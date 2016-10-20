﻿using System.Web;
using System.Web.Optimization;

namespace ContosoUniversity
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
                       "~/Scripts/bootstrap.js",
                        "~/Scripts/jquery.flexslider.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                       "~/Content/font-awesome.css",
                      "~/Content/site.css"));


            bundles.Add(new StyleBundle("~/Content/FileUpload").Include(
                  "~/Content/jQuery.FileUpload/css/jquery.fileupload.css",
                   "~/Content/jQuery.FileUpload/css/jquery.fileupload-ui.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/FileUpload").Include(
          //<!-- The Templates plugin is included to render the upload/download listings -->
                          "~/Scripts/jQuery.FileUpload/vendor/jquery.ui.widget.js",
                       "~/Scripts/jQuery.FileUpload/tmpl.min.js",
                        //<!-- The Load Image plugin is included for the preview images and image resizing functionality -->
                        "~/Scripts/jQuery.FileUpload/load-image.all.min.js",
                        //<!-- The Canvas to Blob plugin is included for image resizing functionality -->
                        "~/Scripts/jQuery.FileUpload/canvas-to-blob.min.js",
                        //"~/Scripts/file-upload/jquery.blueimp-gallery.min.js",
                        //<!-- The Iframe Transport is required for browsers without support for XHR file uploads -->
                        "~/Scripts/jQuery.FileUpload/jquery.iframe-transport.js",
                        //<!-- The basic File Upload plugin -->
                        "~/Scripts/jQuery.FileUpload/jquery.fileupload.js",
                        //<!-- The File Upload processing plugin -->
                        "~/Scripts/jQuery.FileUpload/jquery.fileupload-process.js",
                        //<!-- The File Upload image preview & resize plugin -->
                        "~/Scripts/jQuery.FileUpload/jquery.fileupload-image.js",
                        //<!-- The File Upload audio preview plugin -->
                        "~/Scripts/jQuery.FileUpload/jquery.fileupload-audio.js",
                        //<!-- The File Upload video preview plugin -->
                        "~/Scripts/jQuery.FileUpload/jquery.fileupload-video.js",
                        //<!-- The File Upload validation plugin -->
                        "~/Scripts/jQuery.FileUpload/jquery.fileupload-validate.js",
                        //!-- The File Upload user interface plugin -->
                        "~/Scripts/jQuery.FileUpload/jquery.fileupload-ui.js"));


            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
