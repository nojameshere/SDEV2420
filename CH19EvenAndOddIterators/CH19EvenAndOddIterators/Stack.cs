using System;
using System.Collections;
namespace CH19EvenAndOddIterators
{
    public class Stack<T> : IEnumerable<T>
    {
        private T[] values = new T[15];
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
        public IEnumerable<T> TopToBottom
        {
            get { return this; }
        }
        public IEnumerable<T> BottomToTop
        {
            get
            {
                for (int index = 0; index <= top - 1; index++)
                {
                    yield return values[index];
                }
            }
        }
        public IEnumerable<T> Evens
        {
            get
            {
                for (int index = 0; index <= top; index += 2)
                {
                    yield return values[index];
                }
            }
        }
        public IEnumerable<T> Odds
        {
            get
            {
                for (int index = 1; index <= 10; index += 2)
                {
                    yield return values[index];
                }
            }
        }
    }
}

