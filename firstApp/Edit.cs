using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEX
{
    class Edit
    {
        public void editNote()
        {
            Console.WriteLine("Which note you want to edit?");
            string folderPath = $@"{Directory.GetCurrentDirectory()}";

            string[] txtFiles = Directory.GetFiles(folderPath, "*.txt");

            // Display the names of the .txt files
            int x = 0;
            foreach (string txtFile in txtFiles)
            {
                x++;
                Console.WriteLine($"{x}. {Path.GetFileName(txtFile)}");
            }
            Console.Write("ENTER: ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > x || n < 1 )
                {
                    Console.WriteLine("Enter a valid number!");
                }
                else
                {
                    Console.Write("Write your new text: ");
                    string textEdit = Console.ReadLine();
                    File.WriteAllText(txtFiles[n - 1], textEdit);
                    Console.WriteLine($"your Note {Path.GetFileName(txtFiles[n - 1])} was edited!");
                }
            }
            catch
            {
                Console.WriteLine("Enter a valid number!");
            }
        }
    }
}
