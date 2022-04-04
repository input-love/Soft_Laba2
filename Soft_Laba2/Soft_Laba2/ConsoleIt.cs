using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba2
{
    internal class ConsoleIt
    {
        public ConsoleIt()
        {
            BoxGift = new Box("Коробка с подарками");
        }

        public void StartConsole()
        {
            int countMan = GetCountMan();
            CreateGifts(countMan, "Мужчины");

            int countWoman = GetCountWoman();
            CreateGifts(countWoman, "Женщины");

            BoxGift.Info(); // Вывод информации
        }

        private int GetCountMan()
        {
            Console.WriteLine("Сколько мужчин в офисе?:");
            int count = Convert.ToInt32(Console.ReadLine());
            return count;
        }

        private int GetCountWoman()
        {
            Console.WriteLine("Сколько женщин в офисе?:");
            int count = Convert.ToInt32(Console.ReadLine());
            return count;
        }

        private void CreateGifts(int count, string gender)
        {
            var boxGender = new Box(gender);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Для кого подарок?:");
                string name = Console.ReadLine();

                Console.WriteLine($"Сколько подарков для {name}?:");
                int countGift = Convert.ToInt32(Console.ReadLine());

                var boxForPerson = new Box(name);
                for (int j = 0; j < countGift; j++)
                {
                    Console.WriteLine($"Какой подарок вы подарите {name}?:");
                    string nameGift = Console.ReadLine();

                    boxForPerson.Append(new Gift(nameGift));
                }

                boxGender.Append(boxForPerson);
            }

            BoxGift.Append(boxGender);
        }

        private Box BoxGift { get; set; }
    }
}
