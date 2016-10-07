using DotCore.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBase.Collection.Util
{
    public static class DictionaryExtensions
    {
        private static readonly Random sRandom = new Random((int)(DateTimeUtil.CurrentUnixEpochMillis() / 10000L));

        public static IDictionary<TKey, TValue> Shuffle<TKey, TValue>(this IDictionary<TKey, TValue> map)
        {
            return Shuffle<TKey, TValue>(map, sRandom);
        }
        public static IDictionary<TKey, TValue> Shuffle<TKey, TValue>(this IDictionary<TKey, TValue> map, Random rand)
        {
            // IDictionary is not ordered,
            // and hence we cannot really "shuffle" it.
            // But, in practice, the Dictionary implementation preserves the original insertion orde (through add/removal).
            // Therefore, sorting or randomizing makes sense.

            // Quick and dirty randomizing...
            return map.OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);
        }

    }
}
