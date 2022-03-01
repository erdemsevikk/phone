using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EronPhoneProject.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Telephone { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
    }
}