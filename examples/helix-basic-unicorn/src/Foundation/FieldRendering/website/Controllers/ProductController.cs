using System.Web.Mvc;
using Sitecore.Mvc.Controllers;

namespace BasicCompany.Feature.Product.Controllers
{
    public class ProductController : SitecoreController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}