using System;

namespace HTTP_APi
{
    public class Student
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Group { get; set; }
        public Student(string FirstName, string  MiddleName, string LastName, int Group, int id = 0)
        {
            this.Id = id;
            this.FirstName = FirstName;
            this.MiddleName = FirstName;
            this.LastName = FirstName;
            this.Group = Group;
        }
    }
}
