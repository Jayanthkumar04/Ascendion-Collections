using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample3
{
    public delegate void SpinAction(ref int energy,ref int probability, int value);
    public class Program
    {
        public void SpinActionMain(ref int energy,ref int probability,int value)
        {
            switch (value)
            {
                case 1:
                    energy += 1;
                    probability += 10;
                    break;
                case 2:
                    energy += 2;
                    probability += 20;
                    break;
                case 3:
                    energy -= 3;
                    probability -= 30;
                    break;
                case 4:
                    energy += 4;
                    probability += 40;
                    break;
                case 5:
                    energy += 5;
                    probability += 50;
                    break;
                case 6:
                    energy -= 1;
                    probability -= 60;
                    break;
                case 7:
                    energy += 1;
                    probability += 70;
                    break;
                case 8:
                    energy -= 2;
                    probability -= 30;
                    break;
                case 9:
                    energy -= 3;
                    probability -= 30;
                    break;
                case 10:
                    energy -= 10;
                    probability -= 100;
                    break;
                default:
                    break;



            }


        }

        static void Main(string[] args)
        {
            Program p = new Program();

            SpinAction spin = new SpinAction(p.SpinActionMain);

            int EnergyLevel = 1;
            int WinningPropability = 50;



            Random rm = new Random();

            rm.Next(1, 11);
            int noOfSpins = 5;

            while (noOfSpins != 0)
            {
                Console.WriteLine("spin the number");
                
                int value = rm.Next(1, 11);

                Console.WriteLine(value);
                spin.Invoke(ref EnergyLevel, ref WinningPropability, value);
                Console.WriteLine("energy level" + EnergyLevel + "winning probability" + WinningPropability);

                noOfSpins--;
            }

            Console.WriteLine("energy level" + EnergyLevel + "winning probability" + WinningPropability);

            if (EnergyLevel >= 4 && WinningPropability > 60)
            {
                Console.WriteLine("you won");
            }
            else if (EnergyLevel >= 1 && WinningPropability > 50)
            {
                Console.WriteLine("runner");
            }
            else
            {
                Console.WriteLine("looser");
            }
        }
    }

}
