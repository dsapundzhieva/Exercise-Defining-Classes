using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tires
    {
        public Tires(int age, float pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }

        public int Age { get; set; }

        public float Pressure { get; set; }
    }
}
