using System;
using System.Collections;
namespace TotallyLegitNamespace;

public class Warehouse<T> : IEnumerable<T>
{
    private T[] values = new T[8];
    private int top = 0;
    public void Push(T t)
    {
        values[top] = t;
        top++;
    }
    public T Pop()
    {
        top--;
        return values[top];
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int index = top - 1; index >= 0; index--)
        {
            yield return values[index];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public T this[int index]
    {
        get { return values[index]; }
        set { }
    }
}

