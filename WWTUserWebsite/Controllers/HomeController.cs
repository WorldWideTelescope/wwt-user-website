//-----------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation 2011. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Web.Mvc;

namespace WWTUserWebsite.Controllers
{
    /// <summary>
    /// Controller for handling the home page request which makes request to repository and get the
    /// required data and pushes them to the View.
    /// </summary>
    public class HomeController : ControllerBase
    {
        // This function was necessary to help with issues related to Windows Live logins.
        // May no longer be necessary?
        public ActionResult Startup()
        {
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Index Action for rendering the home page.
        /// </summary>
        /// <returns>Returns the View to be used</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Excel Add-in Help Action for rendering the ExcelAddInHelp page.
        /// </summary>
        /// <returns>Returns the View to be used</returns>
        public ActionResult ExcelAddInHelp()
        {
            return View();
        }
    }
}
