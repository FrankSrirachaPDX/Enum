using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    public enum DaysOfTheWeek
    {
        myDay,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            string holder;
            bool realDay = false;
            
            Console.WriteLine("What day is it today?");
            holder = Console.ReadLine();

            Enum.TryParse(holder, out DaysOfTheWeek myDay);

            for (int i=1; i<=7;i++)
            {
                if(myDay == (DaysOfTheWeek)i)
                {
                    Console.WriteLine("I've seen a lot of {0}s and this sure is one of them.", (DaysOfTheWeek)i);
                    realDay = true;
                }
                if (i ==7 && realDay == false)
                {
                    Console.WriteLine("You best enter a real day next time.");
                }
               
            }

            Console.ReadLine();
        }
    }
}
