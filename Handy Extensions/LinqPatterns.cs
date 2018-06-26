using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
// ReSharper disable PossibleNullReferenceException
// ReSharper disable AssignNullToNotNullAttribute

namespace Handy_Extensions
{
    public static class LinqPatterns
    {
        public static int[] IndexesOf<T>(this IEnumerable<T> collection, T value)
		{
			var indexes = new List<int>();
			var i = 0;
			foreach (var item in collection)
			{
				if (item.Equals(value)) indexes.Add(i);
				i++;
			}

			return indexes.ToArray();
		}

		public static int ClearFrom<T>(this IList<T> collection, T value)
		{
			var indexes = collection.IndexesOf(value);
			for (var i = indexes.Length - 1; i >= 0; i--)
			{
				collection.RemoveAt(indexes[i]);
			}

			return indexes.Length;
		}

		public static IList<T> Trim<T>(this IList<T> collection, int index)
		{
			for (var i = collection.Count - 1; i >= index; i--)
			{
				collection.RemoveAt(i);
			}

			return collection;
		}

		public static IList<T> ForEach<T>(this IList<T> collection, Action<T> action)
		{
			foreach (var item in collection) action(item);
			return collection;
		}

		public static IList<T> ForEach<T, TR>(this IList<T> collection, Func<T, TR> action)
		{
			foreach (var item in collection) action(item);
			return collection;
		}

		public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
		{
			foreach (var item in collection) action(item);
		}

		public static void ForEach<T, TR>(this IEnumerable<T> collection, Func<T, TR> action)
		{
			foreach (var item in collection) action(item);
		}

		public static IEnumerable<T> Cast<T>(this IDictionary dictionary)
		{
			foreach (T item in dictionary) yield return item;
		}

		public static IEnumerable<T> ToEnumerable<T>(this T singleItem) { yield return singleItem; }

		public static IEnumerable<T> Concat<T>(this IEnumerable<T> collection, T singleItem) =>
			collection.Concat(singleItem.ToEnumerable());

		public static IEnumerable<T> Concat<T>(this IEnumerable<T> collection, params T[] items) =>
			Enumerable.Concat(collection, items);

		public static IList<T> AppendRange<T>(this IList<T> target, IEnumerable<T> source)
		{
			foreach (var item in source) target.Add(item);
			return target;
		}

		public static IDictionary<TKey, TValue> AppendRange<TKey, TValue>(this IDictionary<TKey, TValue> target,
			IEnumerable<KeyValuePair<TKey, TValue>> source)
		{
			foreach (var item in source) target.Add(item);
			return target;
		}
    }
}