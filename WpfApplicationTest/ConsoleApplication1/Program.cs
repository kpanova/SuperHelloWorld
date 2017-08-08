using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human men = new Male("Harry");
            men.SayHello();
            Female female = men.ChangeSex() as Female;
            if (female != null)
            {
                female.SaySomething(new Word(female.SayName() + " have change sex! Ohoo!"));
            }

            Console.ReadKey();
        }
    }
}
