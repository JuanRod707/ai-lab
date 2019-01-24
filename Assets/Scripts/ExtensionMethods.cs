using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class ExtensionMethods
{
    public static T PickOne<T>(this IEnumerable<T> source) => source.ToArray()[Random.Range(0, source.Count())];
}