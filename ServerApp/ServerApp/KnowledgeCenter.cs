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
        public void AddStudent(Student student)
        {
            /*Console.WriteLine("Введите фамилию: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите имя:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите ваше отчество:");
            string patronymic = Console.ReadLine();
            Console.WriteLine("Введите группу (если нет - 0): ");
            int group = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(firstName, patronymic, lastName, group);*/ //TODO move to client app
            SQL.AddNewStudent(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            /*Console.WriteLine("Введите фамилию: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите имя:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите ваше отчество:");
            string patronymic = Console.ReadLine();
            Console.WriteLine("Введите группу (если нет - 0): ");*/ //TODO move to client app
            SQL.AddNewTeacher(teacher);
        }
        public Student GetStudent(int id)
        {
            for (int i =0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    return students[i];
                }
            }
            return new Student("Error", "Error", "Error", 0, -1);
        }
        public void AddMark(Student student, Mark mark)
        {
            SQL.AddMark(student, mark);
        }

    }
}
