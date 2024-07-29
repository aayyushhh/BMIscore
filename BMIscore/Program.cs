using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIscore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maxbmi = 0;

            Person[] persons = { new Person(1, "Ayush", 10) , new Person(2, "Ram", 20, 6.3, 87.2) , new Person(3, "Raj", 40, 5.5, 67.2) };

            foreach (Person p in persons)
            {
                p.BMICalculator();
                Console.WriteLine(p);
                Console.WriteLine(p.CheckBodyType());
                if (p.BMI > maxbmi)
                {
                    maxbmi = p.BMI;

                }


            }
            Console.WriteLine("Max BMI " + maxbmi);
            Console.ReadLine();



        }
    }
}
