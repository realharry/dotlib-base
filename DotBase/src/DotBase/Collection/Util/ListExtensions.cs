using DotCore.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotBase.Collection.Util
{
    public static class ListExtensions
    {
        private static readonly Random sRandom = new Random((int)(DateTimeUtil.CurrentUnixEpochMillis() / 10000L));

        public static void Swap<T>(this IList<T> list, int i, int j)
        {
            if (i == j) {
                return;
            }
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        // http://en.wikipedia.org/wiki/Fisher-Yates_shuffle
        // Note:
        // The method signature is a bit confusing, but
        // this is an in-place shuffling (and, hence the input list is updated)
        // We return the same list for convenience (e.g., for chaining.)
        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            return Shuffle<T>(list, sRandom);
        }
        public static IList<T> Shuffle<T>(this IList<T> list, Random rand)
        {
            var n = list.Count;
            while (n > 1) {
                var k = rand.Next(n--);
                list.Swap(k, n);
            }
            return list;
        }

    }
}
