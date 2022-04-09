using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Practise_09._04._2022.Models
{
    public class Car
    {
        public string brand;
        public string model;
        public string color;
        public double maxSpeed;

        public Car()
        {
            Console.WriteLine("Car is created");
        }
        public Car(string brand,string model)
        {
            this.brand = brand;
            this.model = model;
        }
        public Car(string brand, string model,string color,double maxSpeed):this(brand,model)
        {
            this.color = color;
            this.maxSpeed = maxSpeed;
        }
        public virtual string Info()
        {
            return $"Brand => {brand} Model => {model} Color => {color} MaxSpeed => {maxSpeed}";
        }
    }
}
