using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEX
{
    class Show
    {
        public void showNote()
        {
            Console.WriteLine("Which note you want to see?");
            string folderPath = $@"{Directory.GetCurrentDirectory()}";

            string[] txtFiles = Directory.GetFiles(folderPath, "*.txt");

            // Display the names of the .txt files
            int x = 1;
            foreach (string txtFile in txtFiles)
            {
                Console.WriteLine($"{x}. {Path.GetFileName(txtFile)}");
                x++;
            }
            Console.Write("ENTER: ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > x || n < 1)
                {
                    Console.WriteLine("Enter a valid number!");
                }
                else
                {
                    Console.Write($"Your note {Path.GetFileName(txtFiles[n - 1])} is: ");
                    Console.WriteLine(File.ReadAllText(Path.GetFileName(txtFiles[n - 1])));
                }
            }
            catch
            {
                Console.WriteLine("Enter a valid number!");
            }
            
            
        }
    }
}
