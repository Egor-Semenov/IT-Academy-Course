using System;
using System.IO;

namespace FifteenthLessonHW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileSearcher searcher = new MyFileSearcher();
            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\Курсы C#");

            searcher.SearchAndArhivate(directoryInfo, "Text.txt");
        }

        
    }

   
}
