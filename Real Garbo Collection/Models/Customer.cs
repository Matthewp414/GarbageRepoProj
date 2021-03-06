﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Real_Garbo_Collection.Models
{
    public class Customer
    {

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PickUpdate { get; set; }
        public string StreetAddress { get; set; }
        public int zip { get; set; }
        public string SuspendStart { get; set; }
        public string SuspendEnd { get; set; }
        public int balance { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }




    }
}