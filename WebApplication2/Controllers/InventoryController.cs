using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class InventoryController : Controller
    {


 
        public ActionResult Index()
        {

            List<InventoryModel> Inv = (List<InventoryModel>)HttpContext.Application["MyList"];
            ViewBag.MyList = Inv;
            return View();
        }

        public ViewResult equipment(int ID)
        {
            List<InventoryModel> Inv = (List<InventoryModel>)HttpContext.Application["MyList"];
            ViewBag.MyList = Inv;
            ViewBag.ID = ID;


            return View();
        }

        public ActionResult LaptopIndex()
        {
            List<InventoryModel> Laptops = new List<InventoryModel>();
            InventoryModel Eq1 = new InventoryModel
            {
                ID = 1,
                Code = "C0001",
                Name = "Laptop Computer",
                Description = "Dell XPS 13 Laptop",
            };

            Laptops.Add(Eq1);

            return View(Laptops);
        }


        public ActionResult ComputerIndex()
        {
            List<InventoryModel> Desktop = new List<InventoryModel>();
            InventoryModel Eq1 = new InventoryModel
            {
                ID = 2,
                Code = "C0002",
                Name = "Desktop Computer",
                Description = "Dell Inspiron 3000 i3646-2600BLK Desktop Computer ",
            };

            Desktop.Add(Eq1);

            return View(Desktop);
        }

        public ActionResult PrinterIndex()
        {
            List<InventoryModel> Printers = new List<InventoryModel>();
            InventoryModel Eq1 = new InventoryModel
            {
                ID = 3,
                Code = "P0003",
                Name = "Printers",
                Description = "Xerox WorkCentre 3215/NI Wireless Mono Laser Multifunction ",
            };

            Printers.Add(Eq1);

            return View(Printers);
        }


        [HttpGet]
        public ActionResult AddCategory()
        {

            List<InventoryModel> Inventorystore = (List<InventoryModel>)HttpContext.Application["MyList"];
            List<string> Catagory = (List<string>)HttpContext.Application["MyCategoryList"];
           
             // HttpContext.Application["Category_List"] = Catagory;
             // ViewBag.Category_List = Catagory;




            return View();
        }


        [HttpPost]
        public ActionResult AddCategory(String category)
        {

            List<string> CategoryList = (List<string>)HttpContext.Application["MyCategoryList"];
            CategoryList.Add(category);
         
            return RedirectToAction("/Index", "Inventory"); 
        }

        // add Items.

        [HttpGet]
        public ViewResult AddItems()
        {

            List<string> CategoryList = (List<string>)HttpContext.Application["MyCategoryList"];
            ViewBag.MyCategoryList = CategoryList;

            if (HttpContext.Application["MyCategoryList"] != null)
            {
                List<String> categorylist = (List<String>)HttpContext.Application["MyCategoryList"];
                List<SelectListItem> select = new List<SelectListItem>();
                foreach (var Item in categorylist)
                {
                    select.Add(new SelectListItem() { Value = Item, Text = Item });
                }
                     ViewBag.category = categorylist;
                      ViewBag.SelectCategoryList = select; }
  
            else {  ViewBag.MyCategoryList = new List<String>();
                ViewBag.MyDropDownList = new List<SelectListItem>(); }
            
            List<InventoryModel> Inv = (List<InventoryModel>)HttpContext.Application["MyList"];
            InventoryModel Inv2 = new InventoryModel();
            int count = 0;

            foreach (var List in (List<InventoryModel>)HttpContext.Application["MyList"])
            {
                if (List.ID > count)
                {
                    count = List.ID;
                }
            }
            count++;

            Inv2.ID = count;

            

            return View(Inv2);
        }

        [HttpPost]
        public ViewResult AddItems(InventoryModel inventory)
        {

            if (ModelState.IsValid)
           {

                List<string> CategoryList = (List<string>)HttpContext.Application["MyCategoryList"];
                ViewBag.MyCategoryList = CategoryList;


                List<InventoryModel> Inv = (List<InventoryModel>)HttpContext.Application["MyList"];
                Inv.Add(inventory);
                ViewBag.MyList = Inv;


                 return View("Index");


            }

            else

               return View();


        }


    }

}








