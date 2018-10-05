using CodeCapital.EnumerableVisualizer;
using System;
using System.Collections.Generic;

namespace EnumerableVisualizer.Tests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var list2 = new List<string> { "Vaso", "Lena", "Helean", "Eva", "Viktoria", "Ada", "Lucia" };

            var list3 = new List<Person>
            {
                new Person("Vaso", 40, new Car("VW", 80, DateTime.Now)),
                new Person("Lena", 45, new Car("Skoda", 300, DateTime.Now.AddDays(-5)))
            };

            var list4 = new List<Car>
            {
                new Car("VW", 80, DateTime.Now.AddDays(-50)),
                new Car("Skoda", 300, DateTime.Now.AddDays(0)),
                new Car("VW 2", 2018, DateTime.Now.AddDays(-10)),
                new Car("B Skoda", 300, DateTime.Now.AddDays(30)),
                new Car("8080 2018", 300, DateTime.Now.AddDays(-500))
            };

            var list5 = new[]
            {
                new Person("Vaso", 40, new Car("VW", 80, DateTime.Now)),
                new Person("Sandy", 23, new Car("Porsche", 300, DateTime.Now.AddDays(-5)))
            };

            DebuggerVisualizer.TestShowVisualizer(list2);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Car Car { get; set; }

        public Person(string name, int age, Car car)
        {
            Name = name;
            Age = age;
            Car = car;
        }
    }

    public class Car
    {
        public string Brand { get; set; }

        public int Speed { get; set; }

        public DateTime DateAdded { get; set; }

        public Car(string brand, int speed, DateTime dateAdded)
        {
            Brand = brand;
            Speed = speed;
            DateAdded = dateAdded;
        }
    }
}
