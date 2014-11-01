using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyValuableCalculator.Models
{
    public class ElementaryMath
    {
        public int Op1 { get; set; }
        public int Op2 { get; set; }
        public int? Result { get; private set; }

        public void Compute()
        {
            this.Result = this.Op1 + this.Op2;
        }
    }
}