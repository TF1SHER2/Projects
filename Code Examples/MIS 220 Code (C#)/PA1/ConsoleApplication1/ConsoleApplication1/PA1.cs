using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Enter the Pokemon's Name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Pokemon's hight in meters");
                double hight = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Pokemon's weight in kilograms");
                double weight = double.Parse(Console.ReadLine());

                double inchHight = hight * 39.3701;
                double ounceWeight = weight * 35.274;

                string hightClass;
                string weightClass;

                if (ounceWeight < 100)
                {
                    weightClass = "Extra Small";
                }
                else if (ounceWeight >=100 && ounceWeight < 500)
                {
                    weightClass = "Normal";
                }
                else
                {
                    weightClass = "Extra Large";
                }

                if (inchHight < 30)
                {
                    hightClass = "Short";
                }
                else if (inchHight >=30 && inchHight < 50)
                {
                    hightClass = "Normal";
                }
                else
                {
                    hightClass = "Tall";
                }

                Console.Write("Your converted " + name + " is " + Math.Round(inchHight, 2) + " inches tall (" + hightClass + "), and weighs " + Math.Round(ounceWeight, 2) + " ounces (" + weightClass + ")");
                Console.ReadLine();
            }

            else
            {
                string name = args[0];
                double weight = double.Parse(args[1]);
                double hight = double.Parse(args[2]);

                double inchHight = hight * 39.3701;
                double ounceWeight = weight * 35.274;

                string hightClass;
                string weightClass;

                if (ounceWeight < 100)
                {
                    weightClass = "Extra Small";
                }
                else if (ounceWeight >= 100 && ounceWeight < 500)
                {
                    weightClass = "Normal";
                }
                else
                {
                    weightClass = "Extra Large";
                }

                if (inchHight < 30)
                {
                    hightClass = "Short";
                }
                else if (inchHight >= 30 && inchHight < 50)
                {
                    hightClass = "Normal";
                }
                else
                {
                    hightClass = "Tall";
                }

                Console.Write("Your converted " + name + " is " + Math.Round(inchHight, 2) + " inches tall (" + hightClass + "), and weighs " + Math.Round(ounceWeight, 2) + " ounces (" + weightClass + ")");
                Console.ReadLine();

            }
        }
    }
}
