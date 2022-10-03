using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCheckLibrary
{
    public class StringCheck
    {
        /// <summary>
        /// Проверка stringNaame на налчие символов: русские буквы, пробел и дефис.
        /// Строка stringName не должна превышеать 50 символов.
        /// </summary>
        /// <param name="stringName"></param>
        /// <returns>
        /// Возвращает либо истину либо ложь.
        /// </returns>
        public bool CheckName(string stringName)
        {
            string regex = @"^(([а-я])|(\s)|(\-))+$";
            string regexWhiteSpace = @"^((\s)|(\-))+$";
            if (Regex.Match(stringName,regexWhiteSpace,RegexOptions.IgnoreCase).Success)
            {
                return false;
            }
            else
            {
                if (Regex.Match(stringName,regex,RegexOptions.IgnoreCase).Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
