using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18._09._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task1");
            Console.WriteLine("Типы данных:   max:       min:");
            Console.WriteLine("byte          " + byte.MaxValue + "          " + byte.MinValue);
            Console.WriteLine("sbyte         " + sbyte.MaxValue + "         " + sbyte.MinValue);
            Console.WriteLine("short         " + short.MaxValue + "       " + short.MinValue);
            Console.WriteLine("ushort        " + ushort.MaxValue + "        " + ushort.MinValue);
            Console.WriteLine("int           " + int.MaxValue + "  " + int.MinValue);
            Console.WriteLine("task2");
            Console.WriteLine("Введите Ваше имя");
            string name, city;
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите Ваш город");
            city = Convert.ToString(Console.ReadLine());
            int age, pin;
            Console.WriteLine("Введите Ваш возраст");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Ваш Pin-код");
            pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя:" + name);
            Console.WriteLine("Ваш город:" + city);
            Console.WriteLine("Ваш возраст:" + age);
            Console.WriteLine("Ваш pin-код:" + pin);

            Console.WriteLine("task3а");
            string str;
            Console.Write("Введите строку(маленькие буквы): ");
            str = Console.ReadLine();
            str = str.ToUpper();
            Console.WriteLine("Полученная строка(заглавные):" + str);
            Console.ReadKey();

            Console.WriteLine("task3b");
            string str1;
            Console.Write("Введите строку(заглавные буквы): ");
            str1 = Console.ReadLine();
            str1 = str1.ToLower();
            Console.WriteLine("Полученная строка(маленькие):" + str1);
            Console.ReadKey();

            Console.WriteLine("task 4");
            Console.Write("Введите строку-");
            string str2;
            str1 = Console.ReadLine();
            Console.Write("Введите подстроку-");
            str2 = Console.ReadLine();
            int count = -1;
            int i = 0;
            do
            {
                i = str1.IndexOf(str2, i) + 1;
                count++;
            }
            while (i != 0);
            Console.WriteLine($"Количество вхождений подстроки в строку: {count}");

            Console.WriteLine("task5");
            double speedinkm, speedinsm;
            Console.WriteLine("Введите скорость в км/час-");
            speedinkm = Convert.ToDouble(Console.ReadLine());
            speedinsm = speedinkm / 0.036;
            Console.WriteLine("Скорость в см/с:" + Math.Floor(speedinsm));

            Console.WriteLine("task 6");
            Console.Write("Введите возраст отца-");
            double dadsage = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите возраст сына-");
            double sonsage = Convert.ToByte(Console.ReadLine());
            double difference = dadsage / sonsage;
            double dadsage1 = dadsage;
            if (difference == 2)
            {
                Console.WriteLine("Отношение возраста отца к возрасту сына уже равно 2.");
            }
            else
            {
                if (difference < 2)
                {
                    while (difference != 2)
                    {
                        dadsage--;
                        sonsage--;
                        difference = dadsage / sonsage;
                    }
                    double delta = dadsage- dadsage1;
                    Console.WriteLine("Отец был вдвое старше сына" + delta + " лет назад.");
                }
                else
                {
                    while (difference != 2)
                    {
                        dadsage++;
                        sonsage++;
                        difference = dadsage / sonsage;
                    }
                    double delta = dadsage - sonsage;
                    Console.WriteLine("Отец будет вдвое старше сына через " + delta + " лет.");
                }
            }

            Console.WriteLine("task 7");
            double normPrice, salePrice, holidayPrice, value, result;
            Console.Write("Розничная цена бутылки-");
            normPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Скидка в DutyFree (в %)-");
            salePrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Возможные расходы на отпуск: ");
            holidayPrice = Convert.ToDouble(Console.ReadLine());
            value = (salePrice / 100) * normPrice;
            result = (holidayPrice / value); 
            Console.WriteLine("Необходимое количество бутылок на отпуск:" + result);





        }
    }
}
