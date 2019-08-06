using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14_BillInheritance
{
    public class TippableBill : Bill
    {
        public double Tip { get; set; }

        public TippableBill()
        {
            // default constructor
        }

        public TippableBill(double subtotal, double taxRate, double tip)
        {
            this.Tip = tip;
            this.Subtotal = subtotal;
            this.TaxRate = taxRate;
        }

        override public double CalcTotal()
        {
            return ((Subtotal * (1 + TaxRate)) + Tip);
        }
    }
}
