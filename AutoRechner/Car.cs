using AutoRechner.Extra;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRechner
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public string Comment { get; set; }

        public DateTime BuyDate { get; set; }

        public List<Item> Costs { get; }

        public Address Customer { get; set; }

        public HashSet<string> People
        {
            get
            {
                HashSet<string> people = new HashSet<string>();

                foreach (Item item in Costs)
                {
                    if (item.Person == Properties.Resources.UserNone || string.IsNullOrEmpty(item.Person)) continue;

                    if (!people.Contains(item.Person))
                    {
                        people.Add(item.Person);
                    }
                }

                if (!people.Contains(DownPaymentPerson))
                {
                    people.Add(DownPaymentPerson);
                }

                if (!people.Contains(PaymentPerson))
                {
                    people.Add(PaymentPerson);
                }

                return people;
            }
        }

        public int ID { get; set; }

        public Car()
        {
            Brand = string.Empty; ;
            Model = string.Empty; ;
            Comment = string.Empty;
            BuyDate = DateTime.Today;
            Costs = new List<Item>();
        }

        public Car(int id, DateTime date, string brand, string model)
        {
            Brand = brand;
            Model = model;
            ID = id;
            BuyDate = date;

            Costs = new List<Item>();
        }

        public float DownPayment { get; set; } = 0.0f;
        public string DownPaymentPerson { get; set; } = Properties.Resources.UserNone;

        public float Payment { get; set; } = 0.0f;
        public string PaymentPerson { get; set; } = Properties.Resources.UserNone;

        public float SellPrice { get { return DownPayment + Payment; } }

        public float TotalCost
        {
            get
            {
                return Costs.Where(x => x.Include).Sum(x => x.Price);
            }
        }

        public float Win
        {
            get
            {
                return SellPrice - TotalCost;
            }
        }

        public override bool Equals(object obj)
        {
            Car c = (Car)obj;

            return c.ID == ID;
        }

        public override int GetHashCode()
        {
            return ID;
        }
    }
}
