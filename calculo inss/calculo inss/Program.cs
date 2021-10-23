using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_inss
{
    class Program
    {
        static void Main(string[] args)
        {
            float Inss;
            Console.WriteLine("digite o numero do CPF do funcionario:");
            var cpf = Int64.Parse(Console.ReadLine());
            Console.WriteLine("digite o numero de denedentes");
            var numDemp = int.Parse(Console.ReadLine());
            Console.WriteLine("digite sua renda");
            var renda = float.Parse(Console.ReadLine());
            
            if (renda < 1045)
            {
                 Inss= (float)(renda * 0.07);
            }
            else if (renda < 2089.60 && renda > 1045.1){

                 Inss = (float) (renda * 0.09);
            }
            else if (renda > 2089.61 && renda < 3134.40)
            {

                 Inss = (float)(renda * 0.12);
            }
            else {
                 Inss = (float)(renda * 0.12);
            }

            var desconDepend = (float)numDemp * 189.59;

            var imposto = renda - Inss - desconDepend;

            // calculo Irrf
            if (imposto > 1903.99 && imposto < 2826.65)
            {
                imposto= (float)(imposto-142.80);
            }

            else if (imposto > 2826.66 && imposto < 3751.05)
            {
                imposto = (float)(imposto-354.80);
            }
            else if (imposto > 3751.06 && imposto < 4664.68)
            {
                imposto = (float)(imposto-636.13);
            }
            else if (imposto > 4664.68)
            {
                imposto = (float)(imposto-354.80);
            }
            

            
            Console.WriteLine($"O valor final é de  R${imposto}");

            Console.ReadKey();
        }
    }
}
