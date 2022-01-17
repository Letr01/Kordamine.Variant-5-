using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ülesanne 1
            Console.WriteLine("Введите строку произвольной длины:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите символ для того что бы найти процент его вхождения в строку:");
            char sym = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int length = str.Length;
            char[] strArr = str.ToCharArray();
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (strArr[i] == sym)
                {
                    counter++;
                }
            }
            double lengthDouble = Convert.ToDouble(length);
            double counterDouble = Convert.ToDouble(counter);
            double prc = (counterDouble / lengthDouble) * 100;
            Console.WriteLine($"Процент вхождения символа {sym} равен {prc}%");

            //Ülesanne 2
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var a = new int[n];
            var r = new Random();
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                a[i] = r.Next(-100, 100);
                if (a[i] > -10 && a[i] < 10) count++;
            }
            Console.WriteLine("Count {0}", count);

            //Ülesanne 3
            Console.WriteLine("Введите вашу брутто зарплату: ");
            double qwerty = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите налоговый процент: ");
            double qwert = Int32.Parse(Console.ReadLine());
            double qwerty1 = qwerty * (qwert / 100);
            Console.WriteLine($"Ваш подоходный налог равен: {qwerty1} евро");
            double qwerty3 = qwerty - qwerty1;
            Console.WriteLine($"Ваша нетто зарплата: {qwerty3} евро");
        }
    }
}