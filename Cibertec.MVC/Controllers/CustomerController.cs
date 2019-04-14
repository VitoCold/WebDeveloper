using Cibertec.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cibertec.Repositories.Dapper.Northwind;
using System.Configuration;
using Cibertec.Models;

namespace Cibertec.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unit;

        public CustomerController()
        {
            _unit = new NorthwindUnitOfWork(
                ConfigurationManager.ConnectionStrings["NorthwindConnection"].ConnectionString);
         }
        // GET: Customer
        public ActionResult Index()
        {
            return View(_unit.Customers.GetList());
        }

        public ActionResult Details(int id)
        {
            return View(_unit.Customers.GetyById(id));
        }

        public ActionResult DetailsName(string clientName)
        {
            return View("Details",nombreCliente(clientName));
        }

        private Customer nombreCliente(string clienteName)
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
    }
}