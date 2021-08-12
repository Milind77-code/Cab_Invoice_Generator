using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("<--------Welcome to Cab Invoice Generator-------->");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare :  {fare}");
        }
    }
}