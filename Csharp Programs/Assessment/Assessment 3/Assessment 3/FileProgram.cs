
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System;
using System.IO;

namespace Assessment_3
{
    class FileProgram
    {
        static void Main(string[] args)
        {
            string fileName = @"myfile1.txt";
            bool fileExists = File.Exists(fileName);

            Console.WriteLine("\nAppend some text to an existing file:\n");
            Console.WriteLine("--------------------------------------------\n");

            FileWriter(fileName, "Adding Some more Data", fileExists);
            ReadAndPrintFileContent(fileName);
            Console.ReadKey();
        }

        public static void FileWriter(string filePath, string text, bool fileExists)
        {
            if (!fileExists)
            {
                Console.WriteLine("File doesn't exist");
                FileStream aFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(aFile);
                sw.Write(text);
                sw.Close(); // Close the writer here
                aFile.Close(); // Close the file stream here
            }
            else
            {
                Console.WriteLine("File exists");

                FileStream aFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(aFile);
                sw.Write(text);
                sw.Close(); // Close the writer here
                aFile.Close(); // Close the file stream here
            }
        }
        public static void ReadAndPrintFileContent(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("\nReading File Content:\n");

                // Read the entire file and display it
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}
