using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Salutation
    {
        public string Greeting
        {
            get
            {
                return DateTime.Now.Hour < 12 ? "Good morning" : "Good afternoon";
            }
        }
    }
}