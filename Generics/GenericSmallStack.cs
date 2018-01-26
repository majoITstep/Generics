using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericSmallStack<T>
    {
        private T[] pole = new T[10];
        private int index = 0;//index ktory ukazuje na vrchol zasobniku
        public void Push(T obj)
        {
            // index push je na konci pola, preto nesmiem pridat
            if (index == pole.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            pole[index] = obj;
            index++;

        }

        public T Pop()
        {
            if (index - 1 < 0)
            {
                throw new IndexOutOfRangeException();
            }
            
            return pole[index--];
        }
    }
}
