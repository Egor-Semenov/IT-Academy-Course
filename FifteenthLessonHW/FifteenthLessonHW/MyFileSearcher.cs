using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenthLessonHW
{
    public class MyFileSearcher
    {
        public void SearchAndArhivate(DirectoryInfo directoryInfo, string fileName)
        {
            FileInfo searchFile = null;

            searchFile = RecursiveSearch(directoryInfo, fileName, searchFile);

            if(searchFile != null)
            {
                var archive = Path.Combine(searchFile.Directory.FullName, Path.GetFileNameWithoutExtension(searchFile.FullName) + ".zip");

                using (var fileStream = new FileStream(archive, FileMode.Create))

                using (ZipArchive zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Create)) 
                    zipArchive.CreateEntryFromFile(searchFile.FullName, searchFile.Name);

                Console.WriteLine($"Файл заархивирован. Путь к архиву : {archive}");
            }
            else
            {
                throw new FileNotFoundException("Файл не найден");
            }

        }

        FileInfo RecursiveSearch(DirectoryInfo directoryInfo, string fileName, FileInfo searchFile)
        {
            if (searchFile != null) return searchFile;

            foreach(var file in directoryInfo.GetFiles())
            {
                if(fileName.Equals(file.Name))
                {
                   return file;
                }
            }

            var directories = directoryInfo.GetDirectories();

            if(directories.Any())
            {
                foreach(var directory in directories)
                {
                    searchFile = RecursiveSearch(directory, fileName, searchFile);
                    if (searchFile != null) return searchFile;
                }
            }

            return null;
        }
    }
}
