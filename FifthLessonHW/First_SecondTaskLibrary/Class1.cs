using System;

namespace First_SecondTaskLibrary
{
    public class ArrayWorker
    {
        public int[] array { get; set; }
        public int newValue { get; set; }
        public int index { get; set; }
        public int[] Invert( int[] arr)
        {
            
            int start = 0;
            int end = arr.Length - 1;
            while(start < end)
            {
                int tmp = arr[start];
                arr[start] = arr[end];
                arr[end] = tmp;
                start++;
                end--;
            }
            return arr;
        }

        public int[] NewValue( int[] source, int newValue, int index)
        {
            Array.Resize(ref source, source.Length + 1);
            for (int i = source.Length - 1; i > index; i--) 
            {
                source[i] = source[i - 1];
            }
            source[index] = newValue;
            return source;
        }
    }
}
