using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplication2.Models;

namespace WebApplication2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);




            List<InventoryModel> Equipments = new List<InventoryModel>();
            InventoryModel Eq1 = new InventoryModel
            {
                ID = 1,
                Code = "C0001",
                Category = "Laptop",
                Description = "Powerful. Sleek. Light. Affordable ",
                Name = "Lenovo"
            };

            InventoryModel Eq2 = new InventoryModel
            {
                ID = 2,
                Code = "C0002",
                Category = "Computer",
                Description = " Big! Light! ",
                Name = "Mac Desktop "
            };

            InventoryModel Eq3 = new InventoryModel
            {
                ID = 3,
                Code = "P0003",
                Category = "Printer ",
                Description = " Fast printer, WiFi, copy! ",
                Name = "MNV Printer"
            };


            Equipments.Add(Eq1);
            Equipments.Add(Eq2);
            Equipments.Add(Eq3);

            Application["MyList"] = Equipments;

           


            List<string> CatList = new List<string>();
            CatList.Add("Printer");
            CatList.Add("Laptop");
            CatList.Add("Computer");

            Application["MyCategoryList"] = CatList;




        }
    }
}
