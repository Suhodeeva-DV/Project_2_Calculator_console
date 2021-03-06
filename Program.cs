using System;

namespace Calculator_console
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            //int.TryParse(Console.ReadLine(), out int num1);
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Ошибка! Вы ввели некорректное число!");
                Environment.Exit(0);
            }
            Console.WriteLine("Введите операцию:");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваш пример:");
            Console.WriteLine($"{num1} {operation} {num2}");
            Console.WriteLine("Ответ:");

            Calculator(num1, operation, num2);
            Exeption(num1, num2);
        }

        static void Calculator (int num1, char operation, int num2)
        {
            switch (operation)
            {
                case '+' :
                    Console.WriteLine(num1 + num2);
                    break;
                case '-' :
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / (double)num2);
                    break;
                default :
                    Console.WriteLine("Вы нажали неизвестный оператор");
                    break;
            }
        }

        public static void Exeption(int x, int y )
        {
            try
            {
                int result = x / y;
            }
            catch  when (y == 0)
            {
                Console.WriteLine("Делить на 0 нельзя!");
            }
        }
    }
}
