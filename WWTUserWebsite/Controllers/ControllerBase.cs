//-----------------------------------------------------------------------
// <copyright file="ControllerBase.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation 2011. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WWTUserWebsite.Controllers
{
    public class ControllerBase : Controller
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the ControllerBase class.
        /// </summary>
        /// <param name="profileService">Instance of profile Service</param>
        public ControllerBase(IProfileService profileService)
        {
            ProfileService = profileService;
        }

        #endregion
    }
}
