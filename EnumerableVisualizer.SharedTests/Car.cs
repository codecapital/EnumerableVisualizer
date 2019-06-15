using System;

namespace EnumerableVisualizer.SharedTests
{
    public class Car
    {
        public string Brand { get; set; }

        public int Speed { get; set; }

        public DateTime? DateAdded { get; set; }

        public Gadget Gadget { get; set; }

        public Car(Gadget gadget) => Gadget = gadget;

        public Car(string brand, int speed, DateTime? dateAdded = null, Gadget gadget = null)
        {
            Brand = brand;
            Speed = speed;
            DateAdded = dateAdded;
            Gadget = gadget;
        }
    }
}