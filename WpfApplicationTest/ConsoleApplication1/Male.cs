using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Male : Human
    {
        public Male(string Name)
        {
            this.Name = Name;
            this.sex = Sex.Male;
            this.hasPines = true;
        }
    }
}
