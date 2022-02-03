using HTTP_APi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp
{
    static public class SQL
    {
       static public List<Student> GetStudents()
       {
            List<Student> studentsToReturn = new List<Student>();
            //TODO add sql
            return studentsToReturn;
       }
        static public List<Teacher> GetTeachers()
        {
            List<Teacher> teachersToReturn = new List<Teacher>();
            //TODO add sql
            return teachersToReturn;
        }
        static public Student GetStudent()
        {
            Student studentToReturn = null;
            //TODO add sql
            return studentToReturn;
        }
        static public Teacher GetTeacher()
        {
            Teacher teacherToReturn = null;
            //TODO add sql
            return teacherToReturn;
        }
        static public int AddNewStudent(Student student)
        {
            //TODO add sql
            return 0;
        }
        static public void AddNewTeacher(Teacher teacher)
        {
            //TODO add sql
        }
        static public void AddMark(int studentId, Mark mark)
        {
            //TODO add sql
        }
    }
}
