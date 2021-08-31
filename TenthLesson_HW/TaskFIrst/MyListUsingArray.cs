using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFirst
{
    public class MyListUsingArray : IList<MyItem>
    {

        private MyItem[] list;
        int position = -1;
        public MyItem this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return list.Length;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return list.IsReadOnly;
            }
        }

        public void Add(MyItem item)
        {
            Array.Resize(ref list, list.Length + 1);
            list.SetValue(item, list.Length - 1);
        }

        public void Clear()
        {
            Array.Clear(list, 0, list.Length);
        }

        public bool Contains(MyItem item)
        {
            
            return Array.Exists(list, element => element.Equals(item));
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        public int IndexOf(MyItem item)
        {
            return Array.IndexOf(list,item);
        }

        public void Insert(int index, MyItem item)
        {
            Array.Resize(ref list, list.Length + 1);
            for (int i = list.Length - 1; i > index; i--)
            {
                list[i] = list[i - 1];
            }
            list.SetValue(item, index);
        }

        public bool Remove(MyItem item)
        {
            int index = -1;

            for(int i = 0; i < list.Length; i++)
            {
                if (list[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            if(index == -1)
            {
                return false;
            }

            for(int i = index; i < list.Length - 1; i++)
            {
                list[i] = list[i + 1];
            }
            Array.Resize(ref list, list.Length - 1);
            return true;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < list.Length - 1; i++)
            {
                list[i] = list[i + 1];
            }
            Array.Resize(ref list, list.Length - 1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }


}
