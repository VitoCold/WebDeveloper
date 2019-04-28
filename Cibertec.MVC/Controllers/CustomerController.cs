using Cibertec.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cibertec.Repositories.Dapper.Northwind;
using System.Configuration;
using Cibertec.Models;
using log4net;

namespace Cibertec.MVC.Controllers
{
    public class CustomerController : BaseController
    {
        //private readonly IUnitOfWork _unit;

        public CustomerController(ILog log, IUnitOfWork unit):base(log,unit)
        {
            //_unit = new NorthwindUnitOfWork(
            //    ConfigurationManager.ConnectionStrings["NorthwindConnection"].ConnectionString);
            //_unit = unit;
         }
        // GET: Customer
        public ActionResult Index()
        {
            _log.Info("");
            return View(_unit.Customers.GetList());
        }

        public ActionResult Details(int id)
        {
            return View(_unit.Customers.GetyById(id));
        }

        public ActionResult DetailsName(string clientName)
        {
            return View("Details",NombreCliente(clientName));
        }

        private Customer NombreCliente(string clienteName)
        {
            var result = new Customer();
      
                if (clienteName != null)
                {
                    var _cliente = _unit.Customers.GetList()
                                        .Where(q => q.FirstName == clienteName)
                                        .FirstOrDefault();
                result = _cliente;
                }
            return result;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _unit.Customers.Insert(customer);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var customer = _unit.Customers.GetyById(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
           var result= _unit.Customers.Update(customer);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var customer = _unit.Customers.GetyById(id);
            _unit.Customers.Delete(customer);

            return RedirectToAction("Index");
        }
    }
}