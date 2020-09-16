using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilitiesLib
{
    public static class ExtensionMethods
    {
        public static void Shuffle<T>(this List<T> list)
        {
            Random random = new Random();
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static T RemoveAndReturnFirst<T>(this List<T> list)
        {
            var currentFirst = list[0];
            list.RemoveAt(0);
            return currentFirst;
        }


        public static bool OutOfRange<T>(this List<T> list, int index) => index >= list.Count || index < 0;


        public static bool NullOrEmpty<T>(this List<T> list) => list == null || !list.Any();



    }
}
