using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using WWTUserWebsite.Models;

namespace WWTUserWebsite.Controllers
{
    [RoutePrefix("")]
    [Route("{action=Index}")]
    public class DefaultController : ControllerBase
    {
        private readonly BaseModel _baseModel = new BaseModel();

        private static readonly string[] ViewGroups = new string[]
            {
                "about",
                "community",
                "download",
                "getinvolved",
                "home",
                "learn",
                "profile",
                "support",
                "terms",
                "upgrade",
                "use"
            };

        public async Task<ActionResult> Index()
        {
            return await GetViewOrRedirect(string.Empty,"index", _baseModel);
        }

        [Route("{group}/{page=Index}")]
        public async Task<ActionResult> ViewResult(string group, string page)
        {
            try
            {
                if (!ViewGroups.Contains(group.ToLower()))
                {
                    return View("~/Views/Support/Error.cshtml", _baseModel);
                }
                if (group.ToLower() == "wwtstories")
                {
                    return Redirect("http://wwtstories.org");
                }
                if (page.Contains(".msi") || (page.ToLower() == "error" && Request.RawUrl.Contains(".msi")))
                {
                    return await GetViewOrRedirect("download","index", _baseModel);
                }

                ViewBag.page = page = GetQsPage(page);
                ViewBag.group = group;

                return await GetViewOrRedirect(group, page, _baseModel);
            }
            catch
            {
                return View("~/Views/Support/Error.cshtml", _baseModel);
            }
        }

        // This function used to implement the openwwt.org "kiosk" mode. It
        // may no longer be useful?
        private async Task<ActionResult> GetViewOrRedirect(string group, string page, BaseModel model)
        {
            if (group == string.Empty) {
                var homeCookie = Request.Cookies["homepage"];
                var rootDir = homeCookie == null || string.IsNullOrEmpty(homeCookie.Value) ? "webclient" : homeCookie.Value;
                return Redirect(rootDir);
            }

            return group.ToLower() == "home" ? View("~/Views/index.cshtml", model) : View("~/Views/" + group + "/" + page + ".cshtml", model);
        }

        //Ensure old webform routes still return the proper view
        private string GetQsPage(string page)
        {
            if (page == "Index" && Request.QueryString.Count == 1 && Request.QueryString["code"] == null)
            {
                page = Request.QueryString.Get(0);
            }
            return page;
        }
    }
}
