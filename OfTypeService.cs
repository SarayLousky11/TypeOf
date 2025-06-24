using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class OfTypeService : IOfType
{
    public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
    {
        List<T> result = new List<T>();

        foreach (object item in enumerable)
        {
            if (item is T tItem)
            {
                result.Add(tItem);
            }
        }

        return result;
    }


    public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
    {
        return enumerable.OfType<TOutput>();
    }

    public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
    {
        return derivedItems.OfType<TBase>();
    }
}
