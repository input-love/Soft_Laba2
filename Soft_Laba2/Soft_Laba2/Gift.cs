using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba2
{
    internal class Gift : IComponent
    {
        public Gift(string name)
        {
            Name = name;
        }

        public void Info()
        {
            Console.WriteLine(Name);
        }

        public string Name { get; set; }
    }
}
