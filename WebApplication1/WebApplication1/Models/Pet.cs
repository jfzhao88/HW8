using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Pet
    {
        public String Name { get; set; }
        public String Description { get; set; }
        
        public DateTime DateRec { get; set; }
        public Int32 Quanity { get; set; }
        public Decimal Price { get; set; }
    }
}