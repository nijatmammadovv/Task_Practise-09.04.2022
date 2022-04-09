using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Practise_09._04._2022.Models
{
    public class Bus:Car
    {
        public int passengerCount;

        public Bus(string brand, string model, string color, double maxSpeed,int passengerCount):base(brand,model,color,maxSpeed)
        {
            this.passengerCount = passengerCount;
        }
        public override string Info()
        {
            return base.Info() + $" PassengerCount => {passengerCount}";
        }
    }
}
