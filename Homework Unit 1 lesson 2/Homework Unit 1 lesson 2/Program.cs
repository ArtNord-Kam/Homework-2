using System;
using System.Collections.Generic;

namespace Homework_Unit_1_lesson_2
{
    internal class Program
    {
        public enum Month
        {
            Январь = 1,
            Февраль = 2,
            Март = 3,
            Апрель = 4,
            Май = 5,
            Июнь = 6,
            Июль = 7,
            Август = 8,
            Сентябрь = 9,
            Октябрь = 10,
            Ноябрь = 11,
            Декабрь = 12
        }

        private static void Main(string[] args) 
        {
            TempandMonth(); 

            Check();
        }

        private static void TempandMonth()
        {
            double minTemp;
            double maxTemp;
            Console.WriteLine("Введите минимальную температуру"); 
            var Temp = Console.ReadLine();
            minTemp = double.Parse(Temp);

            Console.WriteLine("Введите максимальную температуру"); 
            var Temp1 = Console.ReadLine();
            maxTemp = double.Parse(Temp1);

            var average = (minTemp + maxTemp) / 2;
            Console.WriteLine("Вычислем среднюю температуру :" + string.Format("{0:N2}", average));

            Console.WriteLine("Укажите месяц 1-12");
            var x = Console.ReadLine();
            var Month = int.Parse(x);
            Console.WriteLine("Месяц " + (Month) Month);

            var число = string.Empty;
            if ((int.Parse(x) & 1) != 0)
                число = "Не";
            Console.WriteLine($"Вы вывели {число}четное число");

            var зимниеМесяцы = new List<int>(3) {1, 2, 12};

            if (зимниеМесяцы.Contains(Month) & (average > 0))
                Console.WriteLine("Дождливая зима");
        }

       
        private static void Check() 
        {
            var data = DateTime.Now;
            var Магазин = "Дельта";
            var КоличествоПокупок = 17;
            var Цена = 3759;
            Console.WriteLine("Выведем чек на экран");
            Console.WriteLine("{1,10}", "Магазин: ", Магазин) ;
            Console.WriteLine("{1,10}", "Количество покупок: ", КоличествоПокупок);
            Console.WriteLine("{1,10}", "Дата покупок: ", data);
            Console.WriteLine("{1,10}", "Сумма покупок", Цена);
        } 
    }
}