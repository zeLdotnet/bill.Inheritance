using System;

namespace Lab14_BillInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill(15.80, 0.06);
            TippableBill tipBill = new TippableBill(8.5, 0.06, 2);

            Pay(bill);
            Pay(tipBill);

            
        }

        static void Pay(Bill bill)
        {
            Console.WriteLine("$" + bill.CalcTotal()); 
        }
    }
}
