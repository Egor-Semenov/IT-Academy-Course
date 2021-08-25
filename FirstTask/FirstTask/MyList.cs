using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class MyList : IList<MyItem>
    {
        List<MyItem> myCollection;
        public MyItem this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(MyItem item)
        {
            myCollection.Add(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(MyItem item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(MyItem item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, MyItem item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(MyItem item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
