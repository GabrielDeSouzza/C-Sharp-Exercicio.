using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Complexos;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t Soma, Subtração, Multiplicação e Divisão de numerosComplexos\n\n\n\n");


            var CalculoComplexo = new Class1();

                var repedição = 1;
            while (repedição == 1)
            {

                Console.WriteLine("digite o primeiro termo real da conta");
                var real1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite o segundo termo real da conta");
                var real2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite o primeiro termo imaginario da conta");
                var imaginario1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite o segundo termo imaginario da conta");
                var imaginario2 = Convert.ToDouble(Console.ReadLine());




                Console.WriteLine($"A soma é {CalculoComplexo.SomaComplexos(real1, imaginario1, real2, imaginario2)}");

                Console.WriteLine($"A subtração é {CalculoComplexo.SubtraComplexos(real1, imaginario1, real2, imaginario2)}");

                Console.WriteLine($"A multiplicação é {CalculoComplexo.MultiplicaComplexos(real1, imaginario1, real2, imaginario2)}");

                Console.WriteLine($"A divisão é {CalculoComplexo.DividiCompletos(real1, imaginario1, real2, imaginario2)}");

                Console.WriteLine("\n\n Digite 1 para continuar ou 2 para sair");
                repedição =Convert.ToInt32( Console.ReadLine());

                Console.WriteLine("\n\n\n");

                
            }

            Console.WriteLine("\t\t\tObrigado por usar este Software");

            Console.ReadKey();
        }
    }
}
