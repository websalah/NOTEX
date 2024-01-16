using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEX
{
    class Create
    {
        public void newNote()
        {
            Console.Write("Write your Note: ");
            string note = Console.ReadLine();
            Console.Write("Write a name for your file: ");
            string fileName = Console.ReadLine();
            File.WriteAllText($"{fileName}.txt", note);
            Console.WriteLine($"your new Note {fileName}.txt was saved!");
        }
    }
}
