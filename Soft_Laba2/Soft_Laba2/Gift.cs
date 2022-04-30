using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba2
{
    internal class Gift : IComponent
    {
        // Конструктор класса
        public Gift(string name)
        {
            // Приснавние Name - передаваемое имя объекта
            Name = name;
        }

        // Вывод названия объекта
        public void Info()
        {
            Console.WriteLine(Name);
        }

        // Название предмета, который будет тут храниться
        public string Name { get; set; }
    }
}