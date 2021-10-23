using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b; 
            double resu;
            inicio:
            Console.Write("menu:digite uma das opções:\n\n1:+\n2:-\n3:x\n4:/\n");
            int op = int.Parse(Console.ReadLine());
             if(op>4 || op < 1)
            {
                Console.Write("opção inválida");
                goto inicio;
            }
            else
            {
                Console.WriteLine("digite um numero");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("digite outro numero");
                 b = int.Parse(Console.ReadLine());
                if(op == 1) {
                     resu = a + b; }
                else if (op == 2)
                {
                     resu = a - b;
                }
                else if (op == 3)
                {
                    resu = a * b;
                }
                else
                {
                     resu = a / b;
                    if (b == 0)
                    {
                        Console.WriteLine("Não é possivel dividir por 0");
                        goto inicio;
                    }
                }
                Console.WriteLine("a resposta é :"+ resu );
                Console.WriteLine("\n\n\n");
                goto inicio;
            }


        }
    }
}
