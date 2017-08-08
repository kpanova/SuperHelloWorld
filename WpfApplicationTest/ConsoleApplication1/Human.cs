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
        protected bool hasPines;
        protected Sex sex;
        protected string Name;
        public void SayHello()
        {
            Word word = new Word("Hello World! My Name is " + Name + "!");
            Console.WriteLine(word.SetWord());
        }
        public object ChangeSex()
        {
            hasPines = !hasPines;
            if (hasPines)
            {
                return new Male(this.Name);
            }
            else
            {
                return new Female(this.Name);
            }
        }
        public void SaySomething(Word word)
        {
            Console.WriteLine(word.SetWord());
        }
        public string SayName()
        { return Name; }


    }
}
