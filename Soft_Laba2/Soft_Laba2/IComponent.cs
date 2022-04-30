using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba2
{
    interface IComponent
    {
        void Info();
        string Name { get; set; }
    }
}