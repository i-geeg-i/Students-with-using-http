using System;

namespace HTTP_APi
{
    public class Teacher
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Department { get; set; }
        public int Post { get; set; }
        public Teacher(int Id, string FirstName, string  MiddleName, string LastName, int Department, int Post)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Department = Department;
            this.Post = Post
        }
    }
}
