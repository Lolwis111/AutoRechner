using System;
using AutoRechner;
using AutoRechner.Extra;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AutoRechnerUnitTests
{
    [TestClass]
    public class InvoiceTest
    {
        [TestMethod]
        public void BigInvoice()
        {
            Random rand = new Random();

            Car car = new Car(0, DateTime.Now, "Volkswagen", "Passat");
            car.Comment = "2.0 TDI Azurblau";
            for (int i = 0; i < 50; i++)
            {
                car.Costs.Add(new Item(i, true, "Ein sehr teures Teil", (float)rand.NextDouble() * 200, "Tester" ));
            }

            Invoice invoice = new Invoice(car, true);
            invoice.ExportAsPDF("C:/Users/levin/Documents/test.pdf");
        }
    }
}
