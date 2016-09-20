using Backend.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Finanzen
    {
        public IEnumerable<FinanzenPosition> Rechnungen
        {
            get; set;
        }

        public decimal AktuellerSaldo
        {
            get; set;
        }
    }
}