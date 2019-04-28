using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cibertec.MVC.Utils
{
    public static class Service
    {
       //Simula un servicio. SUponiendo que la generacion del nombre del paquete
       //depende de una lógica especial

        public static string GetPackageNumber()
        {
            return "0000-1234-1234";
        }
    }
}