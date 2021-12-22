using System;

namespace HTTP_APi
{
    public class Subject
    {
        public int Id { get; }
        public string Name { get; set; }
        public int SubjectTypeID { get; set; }
        public int TeacherID { get; set; }
        public Subject(int Id, string Name, int SubjectTypeID, int TeacherID)
        {
            this.Id = Id;
            this.Name = Name;
            this.SubjectTypeID = SubjectTypeID;
            this.TeacherID = TeacherID;
        }
    }
}
