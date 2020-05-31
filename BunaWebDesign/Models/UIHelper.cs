using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BunaWebDesign.Models
{
    public static class UIHelper
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static string DoSubstring(string strinput, int length)
        {
            string output = string.Empty;
            if (strinput.Length > length)
            {
                output=strinput.Substring(0, length)+ "...";
            }
            else
            {
                output = strinput;
            }
            return output;
        }
    }
}