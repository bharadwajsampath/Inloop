using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAngle
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(CalculateAngle(9,20));
            Console.WriteLine(CalculateAngle());
            Console.WriteLine(CalculateAngle(9,20));
            Console.WriteLine(CalculateAngle(9,20));
            Console.WriteLine(CalculateAngle(9,20));
            Console.ReadLine();

        }

        /// <summary>
        /// A func to calculate the angle between the mins and hrs hand
        /// </summary>
        /// <param name="hr">Hour == if not provided deflt is 0</param>
        /// <param name="min"> mins , if not provided deflt is 0</param>
        /// <returns></returns>
      private static  int CalculateAngle(double hr=0, double min=0)
        {
          if (hr==0 && min==0)
          {
              hr = DateTime.Now.Hour;
              min = DateTime.Now.Minute;

          }
          // if 24 hr system return the hr -12
            if (hr >=12)
            {
                hr = hr-12;
            }

            // validate the input
            if (hr < 0 || min < 0 || hr > 12 || min > 60)
                Console.WriteLine("Wrong input");

            if (hr == 12) hr = 0;
            if (min == 60) min = 0;

            // Calculate the angles moved by hour and minute hands
            // with reference to 12:00
            int hourangle =   (int) (0.5 * (hr * 60 + min));
            int minangle = (int) (6 * min);

            // Find the difference between two angles
            int angle = Math.Abs(hourangle - minangle);

            // Return the smaller angle of two possible angles
            angle = Math.Min(360 - angle, angle);

            //return the angle between the hands
            return angle;
        }
    }
}
