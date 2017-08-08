using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Female : Human
    {
        public Female(string Name)
        {
            this.Name = Name;
            this.sex = Sex.Female;
            this.hasPines = false;
        }
    }
}
