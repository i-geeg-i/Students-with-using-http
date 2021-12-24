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
        static public void AddNewStudent(Student student)
        {
            //TODO add sql
        }
        static public void AddNewTeacher(Teacher teacher)
        {
            //TODO add sql
        }
        static public void AddMark(Student student, Mark mark)
        {
            //TODO add sql
        }
    }
}
