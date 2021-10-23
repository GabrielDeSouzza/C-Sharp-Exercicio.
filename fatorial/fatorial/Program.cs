using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 0, cont, resu = 0;
            Console.WriteLine("Digite um numero");
            fatorial=int.Parse(Console.ReadLine());
            cont = fatorial-1;
            resu = fatorial * cont;
            while (cont >= 2)
            {
                cont--;
                resu = resu * cont;
            }
            Console.WriteLine("o Resultado é: "+resu);
            

            //com o for
            cont = 0;
            

            for (cont = fatorial - 2; cont < 0; cont--)
            {
                resu = resu * cont;
            }
            Console.WriteLine("o Resultado é: " + resu);

            //com o Do While
            resu = fatorial;
            cont = fatorial - 1;

            do{
                resu = resu * cont;
                cont--;
            }
            while (cont >= 2) ;

            Console.WriteLine("o Resultado é: " + resu);
            Console.ReadKey();




        }
    }
}
