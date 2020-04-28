using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Jalalat.Models
{
    public class Person
    {
        public Person() : base()
        {
                
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Address { get; set; }
    }
}