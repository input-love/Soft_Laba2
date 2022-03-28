using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba2
{
    internal class Box : IComponent
    {
        public Box(string name)
        {
            Name = name;
        }

        public void Append(IComponent component)
        {
            Сontents.Add(component);
        }

        public void Info()
        {
            Console.WriteLine(Name);

            foreach(IComponent component in Сontents)
            {
                component.Info();
            }
        }

        private List<IComponent> Сontents = new List<IComponent>();

        public string Name { get; set; }
    }
}
