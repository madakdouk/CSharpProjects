using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcFirst.Controllers;

namespace mvcFirst.Models
{
    public class user
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}