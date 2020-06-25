using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMgmt.Models;

namespace StudentMgmt.Helpers
{
    class ConsoleIO
    {
        public const string separatorBar = "==========================================";
        public const string StudentLineFormat = "{0, -25}, {1, -15}, {2, 5}";
        public const string PickStudentLineFormat = "{0, 2}, {1, -20}, {2, -15}, {3, 5}";

        public static void PrintStudentListHeader()
        {
            Console.WriteLine(separatorBar);
            Console.WriteLine(StudentLineFormat, "Name", "Major", "GPA");
            Console.WriteLine(separatorBar);


        }

        public static string GetrequiredStringFromUser(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You must enter valid text.");
                    Console.WriteLine("Press any key to continue ...");
                    Console.ReadKey();
                }
                else
                {
                    return input;
                }
            }


        }

        public static void PrintPickListOfStudents(List<Student> students)
        {
            Console.WriteLine(separatorBar);
            Console.WriteLine(PickStudentLineFormat, "Name", "Major", "GPA");
            Console.WriteLine(separatorBar);

            for (int 1 = 0; i < students.Count(); int++)
            {
                Console.WriteLine(PickStudentLineFormat, i + 1, students[i].LastName + "",
                    students[i].Major, students[i].GPA);
            }

            Console.WriteLine();
            Console.WriteLine(separatorBar);

        }

        public static int GetStudentIndexFromUser(string prompt, int count)
        {
            int output;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out output))
                {
                    Console.WriteLine("You must enter valid integer.");
                    Console.WriteLine("Press any key to continue ...");
                    Console.ReadKey();


                }
                else
                {
                    if (output < 0 || output > 4)
                    {
                        Console.WriteLine($"Please choose a student by number between {0} - {1}.", 1, count);
                        Console.WriteLine("Press any key to continue ...");
                        Console.ReadKey();
                    }
                    return output;
                }
            }
        }

        public static decimal GetRequiredDecimalFromUser(string prompt)
        {
            decimal output;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!decimal.TryParse(input, out output))
                {
                    Console.WriteLine("You must enter valid text.");
                    Console.WriteLine("Press any key to continue ...");
                    Console.ReadKey();


                }
                else
                {
                    if (output < 0 || output > 4)
                    {
                        Console.WriteLine("GPA must be between 0 - 4.");
                        Console.WriteLine("Press any key to continue ...");
                        Console.ReadKey();
                    }
                    return output;
                }
            }


        }

        public static string GetYesNoAnswerFromUser(string prompt)
        {
            while (true)
            {
                Console.Write(prompt + " (Y/N)? ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You must enter Y/N text.");
                    Console.WriteLine("Press any key to continue ...");
                    Console.ReadKey();
                }
                else
                {
                    if (input != "Y" && input != "N")
                    {
                        Console.WriteLine("You must enter Y/N text.");
                        Console.WriteLine("Press any key to continue ...");
                        Console.ReadKey();
                    }
                    return input;
                }
            }
        }
    }

}
