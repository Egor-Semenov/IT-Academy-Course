using FirstTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Implementation
{
    public class MyCollection<T> where T : IMovable
    {
        public List<T> myCollection;

        public List<T> AddItem(T item)
        {
            myCollection.Add(item);
            return myCollection;
        }

        public T this[int index]
        {
            get
            {
                return myCollection[index];
            }
        }

        public int NumberOfItems
        {
            get
            {
                return myCollection.Count;
            }
        }

        
            

    }
}
