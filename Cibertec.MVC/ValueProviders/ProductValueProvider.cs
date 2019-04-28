using Cibertec.MVC.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cibertec.MVC.ValueProviders
{
    public class ProductValueProvider : IValueProvider
    {
        public bool ContainsPrefix(string prefix)
        {
            //define que cuando el ModelBinder esta buscando una propiedad
            //el nombre "Package", el ValueProvider va a ejecutar este VP personalizado
            return prefix.Contains("Package");
        }

        public ValueProviderResult GetValue(string key)
        {
            if (ContainsPrefix(key))
            {
                return new ValueProviderResult(Service.GetPackageNumber(), Service.GetPackageNumber(),CultureInfo.InvariantCulture);
            }
            else
            {
                return null;
            }
        }

     
    }

    public class ProductValueProviderFactory : ValueProviderFactory
    {
        public override IValueProvider GetValueProvider(ControllerContext controllerContext)
        {
            return new ProductValueProvider();
        }
    }
}