
using System.Collections;



namespace Stack
{
    public class CustomStack<T>
    {
        private List<T> Stack = new List<T>();
        public void Push(T item)
        {
            Stack.Add(item);
        }



        public T Pop()
        {
            int nr = Stack.Count;
            T _item = Stack.ElementAt(nr - 1);
            Stack.RemoveAt(nr - 1);
            return _item;
        }



        public int size()
        {
            return Stack.Count;
        }
    }
}