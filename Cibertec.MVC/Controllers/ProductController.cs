using Cibertec.Models;
using Cibertec.Repositories.Dapper.Northwind;
using Cibertec.UnitOfWork;
using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cibertec.MVC.Controllers
{
    public class ProductController : BaseController
    {
        //private readonly IUnitOfWork _unit;

        public ProductController(ILog log, IUnitOfWork unit):base(log,unit)
        {
            //_unit = new NorthwindUnitOfWork(
            //    ConfigurationManager.ConnectionStrings["NorthwindConnection"].ConnectionString);
            //_unit = unit;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View(_unit.Products.GetList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult CreatePost()
        {
            var product = new Product();
            bool x = TryUpdateModel(product);
            var y = product.ProductName;
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //[ActionName("Create")]
        //public ActionResult CreatePost([Bind(Include ="ProductName,UnitPrice")] Product product)
        //{
        //    var y = product.ProductName;
        //    return RedirectToAction("Index");
        //}
    }
}