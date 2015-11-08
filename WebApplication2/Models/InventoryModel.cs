using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Collections;

namespace WebApplication2.Models
{
    public class InventoryModel
    {
       

        public int ID { get; set; } 
         [Required(ErrorMessage = "Please enter a code!")] 
         public string Code { get; set; } 
        
         public string Description { get; set; } 
         //[Required(ErrorMessage = "Please select a valid category")] 
         //this isnt necessary since there is a dropdown list
         
        public string Category { get; set; }

        [Required(ErrorMessage = "Please Enter Name!")]
        public string Name { get; set; }


    }














}
