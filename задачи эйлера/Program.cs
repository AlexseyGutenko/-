using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задачи_эйлера
{
    internal class Program
    {
        static void zadachaN1() 
        {
            int summ=0;
            WriteLine("Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9. Сумма этих чисел равна 23.\nНайдите сумму всех чисел меньше 1000, кратных 3 или 5.\n");
            WriteLine("Выпешим все числа кратные 3 или 5 меньше 1000");
            for (int i = 0; i < 1000; i++)
            {
                if (i%3==0||i%5==0)
                {
                    Write(i+",");
                    summ=summ+i;
                }
                else Write("|");
            }
            WriteLine("Выпешим их сумму\nСумма="+summ);
        }
        static void zadacaN2()
        {
            int summ=0;
            int one = 1,two=2;
            Write("1,2,");
            for (int i = 0; i < 4000000; i++)
            {
                i = one + two;
                Write(i+",");
                if (i%2==0)
                {
                    summ = summ + i;
                }
                one = two;
                two = i;
            }
            WriteLine("Сумма"+summ);
        }
        static void zadacaN3()
        {
            int max = 0;
            for (int i = 1; ; i++)
            {
                if (600851475143 % i==0)
                {
                    max = i;
                }
            }
            WriteLine(max);
        }
        static void Main(string[] args)
        {
            WriteLine("выберите номер задачи от 1 до 3");
            int choice=int.Parse(ReadLine());
            switch (choice)
            {
                case 1: 
                    Program.zadachaN1();
                    break;
                case 2:
                    Program.zadacaN2();
                    break;
                case 3:
                    Program.zadacaN3();
                    break;
                default:
                    break;
            }
        }
    }
}
