using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    internal class Human
    {
        /// <summary>
        /// Checks if string consist only of letters
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool Validation(string str)
        {
            
            for (int i = 0; i < str.Length; i++)
            {
                if (!((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z')))
                    return false;
            }
            return true;

        }


        public int Check(in string nameSurname, char letter)
        {
            int letterCount = 0;

            for (int i = 0; i < nameSurname.Length; i++)
            {
                if (letter == nameSurname[i])
                {
                    letterCount++;
                }
            }

            return letterCount;
        }
    }
}
