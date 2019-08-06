using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14_BillInheritance
{
    public class Bill
    {
        public double Subtotal { get; set; }
        public double TaxRate { get; set; }

        public Bill()
        {
            // default constructor
        }

        public Bill(double subtotal, double taxRate)
        {
            this.Subtotal = subtotal;
            this.TaxRate = taxRate;
        }

        public virtual double CalcTotal()
        {
            return (Subtotal * (1 + TaxRate));
        }
    }
}
