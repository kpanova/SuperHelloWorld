using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Human
    {
        protected enum Sex
        {
            Male = 0,
            Female = 1
        }
        protected Sex sex;
        protected string Name;
        public void SayHello()
        {
            Word word = new Word("Hello World! My Name is " + Name + "!");
            Console.WriteLine(word.SetWord());
        }


    }
}
