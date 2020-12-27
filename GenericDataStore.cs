using System.Globalization;
using System;
namespace Indexer
{
    public class GenericDataStore<T>
    {
        private T[] store;
        public GenericDataStore()
        {
            store = new T[10];
        }
        public GenericDataStore(int Length)
        {
            store = new T[Length];
        }

         public T this[int index]
         {
             get
             {
                 if (index < 0 || index >= store.Length)
                     throw new IndexOutOfRangeException("Index out of range");

                 return store[index];
             }
             set
             {
                 if (index < 0 || index >= store.Length)
                     throw new IndexOutOfRangeException("Index out of range");

                 store[index] = value;
             }
         } 
        public T this[string name] => FindNameByString(name);


        private T FindNameByString(string name)
        {
            T value = default(T);
            for (int j = 0; j < this.Length; j++)
            {
                if (store[j].ToString().ToUpper() == name.ToUpper())
                {
                    value = store[j];
                }
            }
            return value;
        }

        public int Length => store.Length;
    }
}