using System;

namespace HTTP_APi
{
    public class Mark
    {
        public int Id { get; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public int Value { get; set; }
        public Mark(int Id, string StudentID, string SubjectID, string Value)
        {
            this.Id = id;
            this.StudentID = StudentID;
            this.SubjectID = SubjectID;
            this.LastName = FirstName;
            this.Value = Value;
        }
    }
}
