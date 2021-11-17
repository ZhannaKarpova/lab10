using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle bot = new Angle();
            bot.setValues(45, 0, 0, 0);
            bot.printValues();
            Console.ReadKey();
         
        }

        class Angle
        {
            private double Grade;

            private double Minutes;

            private double Seconds;

            private double Radians;
            public void setValues(double _Grade, double _Minutes, double _Seconds, double _Radians) {
                Grade = _Grade;
                Minutes = _Minutes;
                Seconds = _Seconds;
                Radians = _Radians = (Grade + Minutes / 60 + Seconds / 3600) * (Math.PI) / 180;
                if (Grade < 0)
                    Radians = -Radians;
            }
            public void printValues()
            {
                System.Console.Write(Grade +"-Grade."+ Minutes + "-Minutes." + Seconds + "-Seconds." + Radians+"-Radians.");
                System.Console.WriteLine();
            }


        }



    }




}         

