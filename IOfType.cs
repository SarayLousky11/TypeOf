using System.Collections;

public interface IOfType
{
    IEnumerable<T> GetOfType<T>(IEnumerable enumerable);
    IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable);
    IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase;
}
