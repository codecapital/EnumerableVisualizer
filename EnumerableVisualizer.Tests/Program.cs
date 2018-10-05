﻿using System;
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
                new Car("VW", 80),
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

            var list6 = new[]
            {
                new Person("Vaso", 40, null),
                new Person("Sandy", 23, new Car("Porsche", 300, DateTime.Now.AddDays(-5)))
            };

            var list7 = new[]
            {
                new Person { Name = "Vaso"},
                new Person()
            };

            var list8 = new[]
            {
                new Gadget("Phone"),
                new Gadget("Radio"),
                new Gadget(""),
                new Gadget("Self Drive"),
                new Gadget("Tv")
            };

            var list9 = new[]
            {
                new Car(new Gadget("Phone")),
                new Car(new Gadget("Radio")),
                new Car(new Gadget("")),
                new Car(new Gadget("Self Drive")),
                new Car(new Gadget("Tv"))
            };

            //DebuggerEnumerableVisualizer.TestShowVisualizer(list4);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Car Car { get; set; }

        public Person()
        {

        }

        public Person(string name, int age, Car car)
        {
            Name = name;
            Age = age;
            Car = car;
        }
    }

    public class Gadget
    {
        public string Name { get; set; }
        public Gadget(string name) => Name = name;
    }

    public class Car
    {
        public string Brand { get; set; }

        public int Speed { get; set; }

        public DateTime? DateAdded { get; set; }

        public Gadget Gadget { get; set; }

        public Car(Gadget gadget) => Gadget = gadget;

        public Car(string brand, int speed, DateTime? dateAdded = null)
        {
            Brand = brand;
            Speed = speed;
            DateAdded = dateAdded;
        }
    }
}
