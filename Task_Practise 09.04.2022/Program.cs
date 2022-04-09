using System;
using Task_Practise_09._04._2022.Models;

namespace Task_Practise_09._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(21,  false,  "Samir",  "Hasanov");
            person.ShowInfo();
            Console.WriteLine("===========================================================================");
            Student student = new Student("Bakalavr", true, "Akif", "Koceriyev", 25, true);
            student.ShowInfo();
            Console.WriteLine("===========================================================================");
            Car car = new Car();
            Console.WriteLine("===========================================================================");
            Car car1 = new Car("Mersedes", "Eclass", "Red", 220);
            Console.WriteLine(car1.Info());
            Console.WriteLine("===========================================================================");
            Bus bus = new Bus("Mersedes", "Canavar", "Red", 100, 30);
            Console.WriteLine(bus.Info());
        }
    }
}
