using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        class Car //class definition
        {
            int gear; //attribute (data)
            int speed; //attribute (data)

            int maxSpeed = 100; //attribute (data)

            public void PrintGear() //behavior (function)
            {
                Console.WriteLine(gear);
            }

            public void SpeedUp() //behavior (function)
            {
                if (speed < maxSpeed)
                {
                    speed = speed + 1;
                    ChangeGear();
                }
            }

            public void SlowDown() //behavior (function)
            {
                if (speed >= 0)
                {
                    speed = speed - 1;
                    ChangeGear();
                }
            }

            private void ChangeGear() //behavior (function)
            {
                if (speed > 80) { gear = 5; }
                else if (speed > 60) { gear = 4; }
                else if (speed > 40) { gear = 3; }
                else if (speed > 20) { gear = 2; }
                else if (speed > 0) { gear = 1; }
                else { gear = 0; }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
