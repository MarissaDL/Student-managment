using StudentMgmt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentMgmt.Data
{
    public class StudentRepository
    {
        private string _filePath;

        public StudentRepository(string filePath)
        {
            _filePath = filePath;
        }
        //list
        public List <Student> List()
        {
            List<Student> students = new List<Student>();

            using (StreamReader sr = new StreamReader(_filePath))
            {
                sr.ReadLine();
                string line;

                while((line = sr.ReadLine()) != null)
                {
                    Student newStudent = new Student();

                    string[]columns = line.Split(',');

                    newStudent.FirstName = columns[0];
                    newStudent.LastName = columns[1];
                    newStudent.Major = columns[2];
                    newStudent.GPA = decimal.Parse(columns[3]);

                    students.Add(newStudent);
                }
            }
                return students;
        }
        //add
        public void Add(Student student)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                string line = CreateCsvForStudent(student);

                sw.WriteLine(line);
            }
        }
        //edit
        public void Edit(Student student, int index)
        {
            var students = List();

            students[index] = student;

            CreateStudentFile(students);

        }
        //delete
        public void Delete(int index)
        {
            var students = List();
            students.RemoveAt(index);

            CreateStudentFile(students);
        }

        private string CreateCsvForStudent(Student student)
        {
            return string.Format("{0}, {1}, {2}, {3}", student.FirstName,
                    student.LastName, student.Major, student.GPA.ToString());
        }
        private void CreateStudentFile(List<Student> students)
        {
            if (File.Exists(_filePath))
                File.Delete(_filePath);

            using (StreamWriter sr = new StreamWriter(_filePath))
            {

                sr.WriteLine("FirstName, LastName, Major, GPA");
                foreach(var student in students)
                {
                    sr.WriteLine(CreateCsvForStudent(student));
                }

            }
        }
    }
}
