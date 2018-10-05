using CodeCapital.EnumerableVisualizer;
using System.Collections.Generic;

namespace EnumerableVisualizer.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var myString = "Hello, World";

            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var list2 = new List<Person>
            {
                new Person("Vaso", 40, new Car("VW", 80)),
                new Person("Lena", 45, new Car("Skoda", 300))
            };

            var list3 = new List<Car>
            {
                new Car("VW", 80),
                new Car("Skoda", 300)
            };

            DebuggerVisualizer.TestShowVisualizer(list);
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

        public Car(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
    }
}
