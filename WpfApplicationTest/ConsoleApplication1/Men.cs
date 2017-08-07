using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Men : Human
    {
        public Men(string Name)
        {
            this.Name = Name;
            this.sex = Sex.Male;
        }
    }
}
