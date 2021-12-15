using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
namespace students
{
    class StudentRegistry
    {
        private List<Student> Students = new List<Student>();

        private static StudentRegistry instance = null;
        public static StudentRegistry GetInstance()
        {
            if (instance == null) instance = new StudentRegistry();
            return instance;
        }
        public void removeStudent(int number)
        {
            Students.RemoveAt(number);
        }
        public void removeStudent(Student student)
        {
            Students.Remove(student);
        }
        public Student getStudent(int number)
        {
            return Students[number];
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public int getStudentCount()
        {
            return Students.Count;
        }
        public void Save()
        {
            string json = JsonSerializer.Serialize(Students);
            FileStream file = new FileStream("students.json", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.Write(json);
            writer.Close();
        
        }
        public void Load()
        {
            
            FileStream file = new FileStream("students.json", FileMode.OpenOrCreate,FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line = reader.ReadLine();
            //Console.WriteLine(line);

            reader.Close();
            try
            {
                Students = JsonSerializer.Deserialize<List<Student>>(line);
            }
            catch
            {
                
            }
            
        }
        public void visitStudents(Visitor visitor) 
        {
            visitor.startVisit();
            for (int i = 0; i < Students.Count; i++)
            {
                visitor.visitStudent(i, Students[i]);
            }
            visitor.finishVisit();
        }
        private StudentRegistry()
        {
        }
        

    }
}
