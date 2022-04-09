using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Practise_09._04._2022.Models
{
    public class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public bool isMarried;
        public Person()
        {

        }
        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Person(int age,bool ismarried,string name,string surname):this(name,surname)
        {
            Age = age;
            isMarried = ismarried;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name => {Name} " +
                $"Surname => {Surname} " +
                $"Age => {Age} " +
                $"Is mariied => {isMarried}");
        }
    }
}
