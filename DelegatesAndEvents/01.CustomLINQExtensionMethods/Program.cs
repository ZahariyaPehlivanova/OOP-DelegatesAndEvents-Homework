using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CustomLINQExtensionMethods
{
    static class Program
    {
        static void Main()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Before filtering: {0}", string.Join(", ", nums));
            var filtered = nums.WhereNot(x => x % 2 == 0);
            Console.WriteLine("Filtered: {0}", string.Join(", ", filtered));

            var studets = new List<Student>
            {
                new Student("Pesho",3),
                new Student("Mariika",6),
                new Student("Gosho",4),
                new Student("Ivan",2),
            };
            Console.WriteLine();
            foreach (var student in studets)
            {
                Console.WriteLine("{0} {1}", student.Name, student.Grade);
            }
            Console.WriteLine("Max grade: {0} ", studets.Max(student => student.Grade));
        }
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();

            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    result.Add(element);
                }
            }
            return result;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> func)
        where TSelector : IComparable
        {
            TSelector max = func(collection.First());

            foreach (var element in collection)
            {
                if (max.CompareTo(func(element)) < 0)
                {
                    max = func(element);
                }
            }
            return max;
        }
    }
}
