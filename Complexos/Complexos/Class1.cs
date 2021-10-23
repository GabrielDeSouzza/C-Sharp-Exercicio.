using System;

namespace Complexos
{
    public class CalculoComplexos
    {
        
        public string SomaComplexos(double numReal1, double numImaginario1, double numReal2, double numImaginario2)
        {
            var resureal = numReal1 + numReal2;
            var resuimaginario = numImaginario1 + numImaginario2;
            return $"RESULTADO: {resureal.ToString()}+{resuimaginario.ToString()}i";
        }
        public string SubtraComplexos(double numReal1, double numImaginario1, double numReal2, double numImaginario2)
        {
            var resureal = numReal1 - numReal2;
            var resuimaginario = numImaginario1 - numImaginario2;
            return $"RESULTADO: {resureal.ToString()}-{resuimaginario.ToString()}i";
        }
        public string MultiplicaComplexos(double numReal1, double numImaginario1, double numReal2, double numImaginario2)
        {
            var resu = numReal1*numReal2;
            var resu2 = numReal1 * numImaginario2;
            var resu3 = numImaginario1 * numReal2;
            var resu4 = numImaginario1 * numImaginario2;

            return $"RESULTADO = {resu4+resu}+{resu2+resu3}i";
        }
        public string DividiCompletos(double numReal1, double numImaginario1, double numReal2, double numImaginario2)
        {
            var resu = numReal1 * numReal2;
            var resu2 = numReal1 * numImaginario2;
            var resu3 = numImaginario1 * numReal2;
            var resu4 = numImaginario1 * numImaginario2;

            return $"RESULTADO = {resu4 + resu}+{resu2 + resu3}i";
        }


    }
}
