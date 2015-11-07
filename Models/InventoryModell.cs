using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Models
{
    public class InventoryModell
    {

        public InventoryModel x { get; set; }
        public IEnumerator<SelectListItem> category { get; set; }
    }
}