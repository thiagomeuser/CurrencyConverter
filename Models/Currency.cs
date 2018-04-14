using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyConverter.Models
{
    public class Currency
    {
        public Currency() { }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Abbr { get; set; }

        public decimal UnitaryValue { get; set; }
    }
}