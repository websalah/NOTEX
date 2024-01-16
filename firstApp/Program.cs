using System;
using System.IO;
using System.Runtime.ConstrainedExecution;

namespace NOTEX
{
    
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NOTEX App!");
            Console.WriteLine("What do you want to do?");
            int y = 0;
            while (y != 5)
            {
                Console.WriteLine("\n1. Create a new Note\n2. Edit a Note\n3. Show your notes\n4. Delete a note");
                Console.Write("ENTER: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Create create = new Create();
                Edit edit = new Edit();
                Show show = new Show();
                Delete delete = new Delete();

                switch (x)
                {
                    case 1:
                        create = new Create();
                        create.newNote();
                        break;
                    case 2:
                        edit = new Edit();
                        edit.editNote();
                        break;
                    case 3:
                        show = new Show();
                        show.showNote();
                        break;
                    case 4:
                        delete = new Delete();
                        delete.deleteNote();
                        break;
                }
            }
        }
    }
}