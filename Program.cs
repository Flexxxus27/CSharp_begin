namespace C__begin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Арифметические операторы: + - / * %
            // Операторы сравнения: == > < >= <= !=
            // Логияеские операторы: && || !=
            // Операторы присваивания: = += -= *= /= &= ^= |=

            //Fizz Buzz
            
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            if (a % 5 == 0) 
            {
                Console.WriteLine("Buzz");
            }else 
            { 
                Console.WriteLine(a);
            }
            

            //Процент от числа
            
            int Num, Pr, Sum;
            Num = Convert.ToInt32(Console.ReadLine());
            Pr = Convert.ToInt32(Console.ReadLine());

            Sum = (Num * Pr) / 100;
            Console.WriteLine(Sum);
            

            //
            
            string a, b, c, d;

            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            d = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32 (a + b + c + d));
            

            // Диапазон

            int a, b, c;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            

            if (a > b)
            {
                (a, b) = (b, a);
            }

            for(int i = a; i < b; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
