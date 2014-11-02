using MyValuableCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyValuableCalculator.ViewModels
{
    public class HomeIndexViewModel
    {
        public ElementaryMath ElementaryMath { get; set; }

        public SelectList ArithmeticOperations
        {
            get
            {
                var items = new Dictionary<ArithmeticOperation, string>
                {
                    { ArithmeticOperation.Addition, "+" },
                    { ArithmeticOperation.Subtraction, "-" },
                    { ArithmeticOperation.Multiplication, "*" },
                    { ArithmeticOperation.Division, "/" }
                };

                return new SelectList(items, "Key", "Value");
            }
        }
    }
}