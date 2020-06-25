using System;
using StudentMgmt.Helpers;
using StudentMgmt.WorkFlow;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgmt
{
    class MainMenu
    {
        

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Student Managment System");
            Console.WriteLine(ConsoleIO.separatorBar);
            Console.WriteLine("1. List Students");
            Console.WriteLine("2. Add Student");
            Console.WriteLine("3. Remove Student");
            Console.WriteLine("4. Edit Student GPA");
            Console.WriteLine("");
            Console.WriteLine("Q - Quit");
            Console.WriteLine(ConsoleIO.separatorBar);
            Console.WriteLine("");
            Console.WriteLine("Enter choice: ");
        }

        private static bool ProcessChoice()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ListStudentWorkflow listWorkflow = new ListStudentWorkflow();
                    listWorkflow.Execute();
                    break;
                case "2":
                    AddStudentWorkflow addWorkflow = new AddStudentWorkflow();
                    addWorkflow.Execute();
                    break;
                case "3":
                    RemoveStudentWorkflow removeStudentWorkflow = new RemoveStudentWorkflow();
                    removeStudentWorkflow.Execute();
                    break;
                case "4":
                    EditStudentWorkflow editStudentWorkflow = new EditStudentWorkflow();
                    editStudentWorkflow.Execute();
                    break;
                case "Q":
                    return false;
                default:
                    Console.WriteLine("That is not a valid choice. Press any key to continue.");
                    Console.ReadKey();
                    break;
            }
            return true;
        }

        public static void Show()
        {
            bool continueRunning = true;
            while(continueRunning)
            {
                DisplayMenu();
                continueRunning = ProcessChoice();
            }
      
        }
    }
}
