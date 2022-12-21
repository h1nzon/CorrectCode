using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectCodeLibrary
{
    public class CorrectCodeClass
    {
        /// <summary>
        /// Будем считать, что некоторый “код” должен содержать 10 цифр.
        ///При этом, первые 9 цифр определяют сам “код”, а последняя цифра является контрольным значением и позволяет определить правильность “кода” следующим образом:
        ///если сумма первых 9 цифр делится на 10, то в конце должен стоять 0
        ///если сумма первых 9 цифр делится на 3, то в конце должна стоять единица 1;
        ///во всех остальных случаях в конце кода стоит цифра 9.
        ///Необходимо реализовать метод, который бы определял, является ли переданная строка правильным “кодом”.
        /// </summary>
        /// <param name="candidate">
        /// Метод принимает в качестве параметра строку. 
        /// </param>
        /// <returns>
        /// Метод возвращает true, если входная строка соответствует следующим условиям:
        ///строка имеет правильную длину;
        ///десятый символ строки(контрольное значение) содержит правильную цифру.
        /// </returns>
        public static bool IsCorrectCode(string candidate)
        {
            double sum = 0;
            //Будем считать, что некоторый “код” должен содержать 10 цифр.
            if(!(candidate.Length == 10))
            {
                return false;
            }
            //если сумма первых 9 цифр делится на 10, то в конце должен стоять 0
            for (int i = 0; i < candidate.Length; i++)
            {
                sum += Char.GetNumericValue(candidate[i]);
            }
            if(sum % 10 == 0 && candidate[candidate.Length - 1] == '0')
            {
                return true;
            }
            //если сумма первых 9 цифр делится на 3, то в конце должна стоять единица 1;
            if(sum % 3 == 0 && candidate[candidate.Length - 1] == '1')
            {
                return true;
            }

            return true;
        }
    }
}
