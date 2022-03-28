using System;
using System.IO;

namespace SysytemIO
{
    public class Program
    {
       public static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\OneDrive\Desktop\SystemIO\SystemIO\Addressbook.txt";

            ReadAllFiles(path);


        }
        public static void FileExists()
        { 
        string path = @"C:\Users\Admin\OneDrive\Desktop\SystemIO\SystemIO\Addressbook.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("file exixst");
            }
            else
            { 
            Console.WriteLine("file not exist");
            
            }

        }
        public static void ReadAllFiles(string path)
        {

            string[] lines;

            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
            Console.WriteLine(lines[3]);
            Console.WriteLine(lines[4]);
            Console.WriteLine(lines[5]);
            Console.WriteLine(lines[6]);
                
        }


    }
}
       
    

