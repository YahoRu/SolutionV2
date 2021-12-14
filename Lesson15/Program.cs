using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу, а затем название файла:");
            string path = Console.ReadLine();
            string fileName = Console.ReadLine();
            bool foundOrNot = false;

            DirectoryInfo dirInfo = new DirectoryInfo(path);

            static void FileFounder(DirectoryInfo dir, string fileName, ref bool foundOrNot)
            {
                var filesFound = new List<FileInfo>();
                FileInfo[] files = null;
                DirectoryInfo[] subDirs = null;

                files = dir.GetFiles();

                if (files != null)
                {
                    foreach (FileInfo file in files)
                    {
                        if (file.Name == fileName && filesFound.Count == 0)
                        {
                            filesFound.Add(file);
                        }
                    }

                    if (filesFound.Count == 0)
                    {
                        subDirs = dir.GetDirectories();

                        foreach (DirectoryInfo dirs in subDirs)
                        {
                            FileFounder(dirs, fileName, ref foundOrNot);
                        }
                    }

                }

                if (filesFound.Count != 0)
                {
                    foreach (var item in filesFound)
                    {
                        using (ZipArchive zip = ZipFile.Open($@"{item.DirectoryName}\Arc({item.Name}).zip", ZipArchiveMode.Update))
                        {
                            zip.CreateEntryFromFile(item.FullName, item.Name);
                        }

                        Console.WriteLine($"Найденый файл заархивирован. Путь: {item.DirectoryName}");

                        item.Delete();

                        foundOrNot = true;

                        return;
                    }
                }
            }

            FileFounder(dirInfo, fileName, ref foundOrNot);

            if (!foundOrNot)
            {
                throw new FileNotFoundException($"Файл {fileName} не найден!");
            }
        }
    }
}
