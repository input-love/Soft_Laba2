using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba2
{
    internal class Box : IComponent
    {
            // Конструктор класса
        //----------------------------------------------------------------
        public Box(string name)
        {
            // Приснавние Name - передаваемое имя объекта
            Name = name;
        }
        //----------------------------------------------------------------

            // Добавление нового компонента
        //----------------------------------------------------------------
        public void Append(IComponent component)
        {
            // Добавление "Сontents" нового объекта
            Сontents.Add(component);
        }
        //----------------------------------------------------------------

            // Вывод иформации по всем переменным List
        //----------------------------------------------------------------
        public void Info()
        {
            // Вывод собственного имени объекта
            Console.WriteLine(Name);

            // Проход по всем элементам List
            foreach(IComponent component in Сontents)
            {
                // Вызов метода "Info"
                component.Info();
            }
        }
        //----------------------------------------------------------------

            // Переменные
        //----------------------------------------------------------------
        // Храниться информация по объектам
        private List<IComponent> Сontents = new List<IComponent>();

        // Название коробки, которая тут будет храниться
        public string Name { get; set; }
        //----------------------------------------------------------------
    }
}
