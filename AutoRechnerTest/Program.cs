using AutoRechner;
using AutoRechner.Extra;
using System;

namespace AutoRechnerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Car car = new Car(0, DateTime.Now, "Volkswagen", "Passat");
            car.Comment = "2.0 TDI Azurblau";
            for (int i = 0; i < 12; i++)
            {
                car.Costs.Add(new Item(i, true, "Ein sehr teures Teil", (float)rand.NextDouble() * 200, "Tester"));
            }

            SettingsManager sm = new SettingsManager() { SellerAddress = new Address("Test", "01099", "Dresden", "Prager Straße 67") };

            Invoice invoice = new Invoice(sm);

            invoice.Create(car, true, new Address("Levin Palm", "12555", "Berlin", "Mittelheide 100"), "Lorem ipsum dolor sit amet, consetetur sadipscing elitr," +
                " sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores " +
                "et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing " +
                "elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores " +
                "et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.");

            invoice.ExportAsPDF("C:/Users/levin/Documents/test.pdf");
        }
    }
}
