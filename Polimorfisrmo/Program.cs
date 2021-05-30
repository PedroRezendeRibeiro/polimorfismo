using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polimorfisrmo.Entities;
using System.Globalization;

namespace Polimorfisrmo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine  ("Enter the number of employees");
            int n = int.Parse(Console.ReadLine());

            for (int i= 1; i <=n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");

                Console.WriteLine("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Hour: ");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                    list.Add(new Employee(name, hours, valuePerHour));

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee  item in list)
            {
                Console.WriteLine(item.Name + " - $ " + item.Payment().ToString("F2"),CultureInfo.InvariantCulture);

            }




            Console.ReadKey();

        }
    }
}
