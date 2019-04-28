using Cibertec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cibertec.MVC.Binders
{
    public class ProductBinder : IModelBinder
    {
        //public bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, 
        //                        ModelBindingContext bindingContext)
        //{
        //    if (bindingContext==null)
        //    {
        //        throw new ArgumentNullException(nameof(bindingContext));
        //    }

        //    if (bindingContext.ModelType==typeof(Product))
        //    {
        //        Product model = (Product)bindingContext.Model ?? new Product();

        //        model.Id = Convert.ToInt32(bindingContext.ValueProvider.GetValue("Id").AttemptedValue);
        //        model.ProductName = bindingContext.ValueProvider.GetValue("ProductName").AttemptedValue;
        //        model.Package = bindingContext.ValueProvider.GetValue("Package").AttemptedValue;
        //        model.IsDiscontinued = Convert.ToBoolean(bindingContext.ValueProvider.GetValue("IsDiscontinued").AttemptedValue);
        //        model.UnitPrice = Convert.ToDecimal(bindingContext.ValueProvider.GetValue("UnitPrice").AttemptedValue);
        //        model.SupplierId = Convert.ToInt32(bindingContext.ValueProvider.GetValue("SupplierId").AttemptedValue);

        //        bindingContext.Model = model;

        //        return true;
        //    }

        //    return false;
        //}
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            if (bindingContext.ModelType == typeof(Product))
            {
                Product model = (Product)bindingContext.Model ?? new Product();

                model.Id = bindingContext.ValueProvider.GetValue("Id") != null ? Convert.ToInt32(bindingContext.ValueProvider.GetValue("Id").AttemptedValue) : 0;
            
                model.ProductName = bindingContext.ValueProvider.GetValue("ProductName").AttemptedValue;
                model.Package = bindingContext.ValueProvider.GetValue("Package").AttemptedValue;
                model.IsDiscontinued = Convert.ToBoolean(bindingContext.ValueProvider.GetValue("IsDiscontinued").AttemptedValue);
                model.UnitPrice = Convert.ToDecimal(bindingContext.ValueProvider.GetValue("UnitPrice").AttemptedValue);
                model.SupplierId = Convert.ToInt32(bindingContext.ValueProvider.GetValue("SupplierId").AttemptedValue);

                return model;
            }

            return false;
        }
    }
}