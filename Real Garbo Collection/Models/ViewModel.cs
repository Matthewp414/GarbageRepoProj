using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_Garbo_Collection.Models
{
    public class ViewModel
    {
        public List<Customer> Customers { get; set; }
        public string Day { get; set; }
        public SelectList ListOfDays { get; set; }



    }
}