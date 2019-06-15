namespace EnumerableVisualizer.SharedTests
{
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
}
