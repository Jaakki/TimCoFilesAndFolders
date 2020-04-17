using System;
using System.IO;

namespace TimCoFilesAndFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"D:\FileSystem";                 //define a name for string and then the path of what is searched. "rootPath" is later used to call said path

            //string[] dirs = Directory.GetDirectories(rootPath, "", SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine($"{dir}");
            //}

            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            /*
            foreach (string file in files)
            {
                Console.WriteLine($"{file}");                                           //shows file names including the full path "D:\FileSystem\WhatEver" !
                Console.WriteLine($"{Path.GetFileName(file)}");                         //shows file names with "extentions" - txt, bmp, jpg, exe
                Console.WriteLine($"{Path.GetFileNameWithoutExtension(file)}");         //shows file names without "extentions"
                Console.WriteLine($"{Path.GetFullPath(file)}");                         //shows file names including the full path "D:\FileSystem\WhatEver" !
                Console.WriteLine($"{Path.GetDirectoryName(file)}");                    //shows file path "where it lives" - "D:\FileSystem"
                var info = new FileInfo(file);
                Console.WriteLine($"{Path.GetFileName(file)} {info.Length} bytes");     //info.Length tells the files size in bytes
            }*/

            //string newDirectoryPath = @"D:\FileSystem\SubFolderMonsters\EncounterLocations\Caves";
            //Directory.CreateDirectory(newDirectoryPath);
            /*
            bool directoryExists = Directory.Exists(newDirectoryPath);

            if (directoryExists)                                                        //if said directory does exist, then we will say "Exists", and if now, we will say "Nope.avi" & create it
            {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("Nope.avi");
                Directory.CreateDirectory(newDirectoryPath);
            }
            */

            //string[] files = Directory.GetFiles(rootPath);
            //string destinationFolder = @"D:\FileSystem\SubFolderPlayer\";

            //foreach (string file in files)
            //{
            //File.Copy(file, $"{destinationFolder}{Path.GetFileName(file)}"/*, true*/); //destinationFolder is where we shall place files from, file in files -> rootPath! --- if overwrite is true, if those already exist, they will be overwriten 
            //}

            //for (int i = 0; i < files.Length; i++)
            //{
            //    File.Copy(files[i], $"{destinationFolder}{i}.txt", false);
            //}

            //foreach (string file in files)
            //{
            //    File.Move(file, $"{destinationFolder}{Path.GetFileName(file)}");
            //}

            var files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);     // "*.txt" will only show us our txt files, you can use others like bmp, jpg, exe

            foreach (string file in files)
            {
                Console.WriteLine($"{file}");                                           //shows file names including the full path "D:\FileSystem\WhatEver" !
                //Console.WriteLine($"{Path.GetFileName(file)}");                         //shows file names with "extentions" - txt, bmp, jpg, exe
                //Console.WriteLine($"{Path.GetFileNameWithoutExtension(file)}");         //shows file names without "extentions"
                //Console.WriteLine($"{Path.GetFullPath(file)}");                         //shows file names including the full path "D:\FileSystem\WhatEver" !
                //Console.WriteLine($"{Path.GetDirectoryName(file)}");                    //shows file path "where it lives" - "D:\FileSystem"
                //var info = new FileInfo(file);
                //Console.WriteLine($"{Path.GetFileName(file)} {info.Length} bytes");     //info.Length tells the files size in bytes
            }
            

           Console.ReadLine();

        }
    }
}
