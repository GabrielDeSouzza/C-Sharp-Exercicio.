using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_treino
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dado = new Random();

            int pontos, dado1, dado2, dado3, bonus=0;

            inicio:

            dado1 = dado.Next(1, 7);
            dado2 = dado.Next(1, 7);
            dado3 = dado.Next(1, 7);

            Console.WriteLine("REGRAS DO JOGO: ");
            Console.WriteLine("Se quaisquer dois dados rolados resultarem no mesmo valor, você receberá dois pontos de bônus pelo resultado duplicado.");
            Console.WriteLine("Se os três dados rolados resultarem no mesmo valor, você receberá seis pontos de bônus pelo resultado triplicado.");
            Console.WriteLine("Se a soma dos três dados rolados, mais quaisquer pontos de bônus, for igual ou maior que 15, você vencerá o jogo. Caso contrário, você perderá.");

            if (dado1 == dado2 || dado1 == dado3 || dado3 == dado2) bonus = 2;

            if (dado1 == dado2 && dado1 == dado3) bonus = 6;

            Console.WriteLine($"dado 1 ={dado1}\ndado 2 {dado2}\ndado3={dado3}\nbonus={bonus}");

            pontos = dado1 + dado2 + dado3 + bonus;

            Console.WriteLine($"Sua pontuação foi de {pontos} pontos");

            if (pontos > 16) Console.WriteLine("Você ganhou um Jato");
            else if (pontos <= 15 && pontos > 8) Console.WriteLine("Você ganhou um sub-marino");

            else Console.WriteLine("Você ganhou um pircem");

            Console.ReadKey();

            goto inicio;



        }
    }
}
