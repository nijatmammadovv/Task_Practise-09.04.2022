using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Practise_09._04._2022.Models
{
    public class Student:Person
    {
        public string Degree;
        public bool isHigh;

        public Student(string degree,bool ishigh,string name,string surname,int age,bool ismarried):base(age,ismarried,name,surname)
        {
            Degree = degree;
            isHigh = ishigh;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Degree => {Degree}" +
                $"Is high => {isHigh}");
        }
    }
}
