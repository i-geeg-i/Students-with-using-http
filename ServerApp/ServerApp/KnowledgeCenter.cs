using HTTP_APi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp
{
    public class KnowledgeCenter
    {
        public List<Student> students 
        {
            get
            {
                return SQL.GetStudents();
            }
        }
        public List<Teacher> teachers
        {
            get
            {
                return SQL.GetTeachers();
            }
        }   
        public void AddStudent()
        {
            Console.WriteLine("Введите фамилию: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите имя:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите ваше отчество:");
            string patronymic = Console.ReadLine();
            Console.WriteLine("Введите группу (если нет - 0): ");
            int group = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(firstName, patronymic, lastName, group);
            SQL.AddNewStudent(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            Console.WriteLine("Введите фамилию: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите имя:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите ваше отчество:");
            string patronymic = Console.ReadLine();
            Console.WriteLine("Введите группу (если нет - 0): ");
            SQL.AddNewTeacher(teacher);
        }
        public void AddMark(Student student, Mark mark)
        {
            SQL.AddMark(student, mark);
        }
    }
}
