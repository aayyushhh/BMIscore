using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIscore
{
    public class Person
    {
        public const double HEIGHT = 5;
        public const double WEIGHT = 50;
        public const double INCHESCONV = 0.3408;
        public int PersonId { get; set; }
        public string Personname { get; set; }
        public double Personage { get; set; }

        public double Personheight { get; set; }

        public double Personweight { get; set; }
        public double BMI { get; set; }

        public Person(int id, string name, double age, double height, double weight)
        {
            PersonId = id;
            Personname = name;
            Personage = age;
            Personheight = INCHESCONV * height;
            Personweight = weight;

        }
        public Person(int id, string name, double age) : this(id, name, age, HEIGHT, WEIGHT)

        {


        }

        public void BMICalculator()
        {
            double score = Personweight / Personheight;
            BMI = score;

        }

        public string CheckBodyType()
        {
            if (BMI < 18.50)
            {
                return "Underweight";
            }
            else if (18.5 < BMI && BMI < 24.9)
            {
                return "Healthy weight";

            }
            else if (25.0 < BMI && BMI < 29.9)
            {
                return "Overweight";
            }

            return "Obesity";
        }

        public override string ToString()
        {
            return $"Id :{PersonId} Name :{Personname} Age :{Personage} Height :{Personheight} Weight :{Personweight} BMI :{BMI}";
        }







    }
}



