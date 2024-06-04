using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    internal class Person
    {
        //Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string[] SexuallyTransmittedDiseases { get; set; }
        
        //Constructor(s)
        public Person() 
        {
            Name = "David";
            Age = 0;
            Gender = true;
            SexuallyTransmittedDiseases = ["Herp", "Clap"];
        }

        public Person(string name, int age, bool gender, string[] redFlags)
        {
            Name = name;
            Age = age;
            Gender = gender;
            SexuallyTransmittedDiseases = redFlags;
        }

        //Methods
    }
}
