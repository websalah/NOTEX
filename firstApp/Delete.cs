using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEX
{
    class Delete
    {
        public void deleteNote()
        {
            Console.WriteLine("Which note you want to delete?");
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
                    File.Delete(Path.GetFileName(txtFiles[n - 1]));
                    Console.WriteLine($"your Note {Path.GetFileName(txtFiles[n - 1])} was deleted!");
                }
            }
            catch
            {
                Console.WriteLine("Enter a valid number!");
            }
            
        }
    }
}
