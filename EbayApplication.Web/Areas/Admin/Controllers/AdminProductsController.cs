using System;
using System.Linq;
using System.Web.Mvc;
using EbayApplication.Repositories;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using EbayApplication.Web.Models.ProductModels;

namespace EbayApplication.Web.Areas.Admin.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminProductsController : Controller
    {
        private readonly IUnitOfWorkData db;

        public AdminProductsController(IUnitOfWorkData unitOfWor)
        {
            this.db = unitOfWor;
        }
        
        public AdminProductsController()
        {
            this.db = new UnitOfWorkData();
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ReadProducts([DataSourceRequest] DataSourceRequest request)
        {
            var products = this.db.Products.All()
                .Select(ProductViewModel.FromProduct);

            return Json(products.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }
	}
}