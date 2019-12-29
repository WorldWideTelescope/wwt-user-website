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
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the HomeController class.
        /// </summary>
        /// <param name="profileService">Instance of profile Service</param>
        public HomeController(IProfileService profileService)
            : base(profileService)
        {
        }

        #endregion Constructor

        /// <summary>
        /// Startup Action which is default action rendering the home page. This needs to be added because of the
        /// issue with WindowsLiveIDAuthenticationModule when a non-fully qualified URL is used which would be the case with
        /// the default action
        /// Additional details at http://sharepoint/sites/liveid/wiki/Wiki%20Pages/AuthModPathlessURLs.aspx
        /// </summary>
        /// <returns>Redirects to Index action</returns>
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
