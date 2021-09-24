using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_pdf_
{
        class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("task1");
            Console.Write("Секунд прошло с  начала суток: ");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" {time / 3600} полных часов прошло с начала суток;");
            Console.WriteLine($" {(time % 3600) / 60} полных минут прошло с начала очередного часа;");
            Console.WriteLine($" {time % 60} полных секунд прошло с начала очередной минуты;");

            Console.WriteLine("task2");
            Console.WriteLine("Дан прямоугольник с размерами 543 мм  х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него ? ");
            int count = 543 / 130;
            Console.WriteLine($"Ответ: {count}");

            Console.WriteLine("task3");
            Console.Write("Пусть x - порядковый номер текущего месяца.\nВведите сколько меcяцев прошло со 2 января 2020 года: ");
            int x = 1;//январь
            time = Convert.ToInt32(Console.ReadLine());//колличество пройденных месяцев
            x = x + time % 12;
            Console.WriteLine($"Порядковый номер полученного месяца:{x}");

            Console.WriteLine("task4");
            x = random.Next(10, 99);
            int y = x / 10; // количество десятков числа
            Console.WriteLine($"Дано двузначное число {x}");
            Console.WriteLine($"а) число десятков в нем: {y}");
            Console.WriteLine($"б) число единиц в нем: {x % 10}");
            Console.WriteLine($"в) сумму его цифр: {x % 10 + y}");
            Console.WriteLine($"г) произведение его цифр: {x % 10 * y}");

            Console.WriteLine("task5");
            x = random.Next(100, 999);
            y = x / 100; // количество сотен числа
            Console.Write($"Дано трехзначное число {x} (abc)");
            x = x % 100 * 10 + y;
            Console.WriteLine($"Число после форматирования:{x} (bca)");

            Console.WriteLine("task6");
            x = 237;
            y = x / 100; // количество сотен числа
            Console.Write($"Дано трехзначное число {x} (cab)");
            x = x % 100 * 10 + y;
            Console.Write($"Обратно его преобразуя, получили {x} (abc)");

            Console.WriteLine(" task7");
            x = random.Next(10, 89);
            y = random.Next(10, 99 - x);
            int a1, a2, b1, b2;
            a1 = x % 10;//единицы
            a2 = x / 10;//десятки
            b1 = y % 10;//единицы
            b2 = y / 10;//десятки
            Console.WriteLine($"Даны цифры чисел a2a1 и b2b1.\n a2 = {a2}\n a1 = {a1}\n b2 = {b2}\n b1 = {b1}");
            int c1 = (b1 + a1) % 10;
            int c2 = a2 + b2 + c1 / 10;
            Console.WriteLine($"a2a1 + b2b1 = c1c2\n c1 = {c2}\n c2 = {c1}");

            Console.WriteLine("task9");
            Console.WriteLine("А = Истина, В = Ложь, С = Ложь");
            Console.WriteLine($"а) А или В = {true || false}\nб) А и В = {true && false}\nв) В или С = {false || false}");

            Console.WriteLine("addtask1");
            Console.Write("Введите количество лепестков цветка Тимми: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество лепестков цветка Сары: ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0 ^ y % 2 == 0)
            {
                Console.WriteLine("Тимми и Сара влюблены");
            }
            else
            {
                Console.WriteLine("К сожалению, Тимми и Сара не влюблены");
            }

            Console.WriteLine("addtask2");
            Console.WriteLine("Введите время велопрогулки Натана (в часах): ");
            float hours = Convert.ToSingle(Console.ReadLine());
            hours = hours* (float)0.5;
            Console.WriteLine($"Натан нужно взять с собой на велопрогулку {Math.Floor(hours)} литров воды.");

            Console.ReadKey();
        }
      
        }
    }
