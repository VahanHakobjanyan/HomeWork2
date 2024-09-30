using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinqImplementation
{
    public static class MyLinq
    {
        public static bool MyAll<TSource>(this IEnumerable<TSource> collection, Func<TSource, bool> predicate)
        {
            foreach (var item in collection)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool MyAny<TSource>(this IEnumerable<TSource> collection, Func<TSource, bool> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }
        public static double MyAverage(this IEnumerable<double> collection)
        {
            double sum = 0;
            int count = 0;
            foreach (var d in collection)
            {
                sum += d;
                count++;
            }
            return sum / count;
        }
        public static IEnumerable<TSource> MyConcat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            foreach (TSource item in first)
            {
                yield return item;
            }
            foreach (TSource item in second)
            {
                yield return item;
            }
        }
        public static bool MyContains<TSource>(this IEnumerable<TSource> collection, TSource item)
        {
            foreach (TSource sourceItem in collection)
            {
                if (sourceItem.Equals(item))
                    return true;
            }
            return false;
        }
        public static int MyCount<TSource>(this IEnumerable<TSource> collection)
        {
            int count = 0;
            foreach (TSource item in collection)
            {
                count++;
            }
            return count;
        }
        public static int MyCount<TSource>(this IEnumerable<TSource> collection, Func<TSource, bool> predicate)
        {
            int count = 0;
            foreach (TSource item in collection)
            {
                if (predicate(item))
                {8
                    count++;
                }
            }
            return count;
        }
        public static IEnumerable<TSource> MyDistinct<TSource>(this IEnumerable<TSource> collection)
        {
            ICollection<TSource> distincts = new List<TSource>();
            foreach (TSource item in collection)
            {
                if (!distincts.MyContains(item))
                {
                    distincts.Add(item);
                }
            }
            return (IEnumerable<TSource>)distincts;
        }
        public static TSource MyElementAt<TSource>(this IEnumerable<TSource> collection, int index)
        {
            if (index >= collection.MyCount() || index < 0)
            {
                return default;
            }
            int currentIndex = 0;
            foreach (TSource item in collection)
            {
                if (currentIndex == index)
                {
                    return item;
                }
                currentIndex++;
            }
            return default;
        }
        public static TSource MyFirst<TSource>(this IEnumerable<TSource> collection)
        {
            foreach (TSource item in collection)
            {
                return item;
            }
            return default;
        }
        public static TSource MyFirst<TSource>(this IEnumerable<TSource> collection, Func<TSource, bool> predicate)
        {
            foreach (TSource item in collection)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default;
        }
        public static TSource MyLast<TSource>(this IEnumerable<TSource> collection) 
        {
            IEnumerable<TSource> tempCollection = collection.Reverse();
            foreach (TSource item in tempCollection)
            {
                return item;
            }
            return default;
        }
        public static TSource MyLast<TSource>(this IEnumerable<TSource> collection, Func<TSource, bool> predicate)
        {
            IEnumerable<TSource> tempCollection = collection.Reverse();
            foreach (TSource item in tempCollection)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default;
        }
    }
}
