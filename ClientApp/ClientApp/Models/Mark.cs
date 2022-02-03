using System;

namespace HTTP_APi
{
    public class Mark
    {
        public int Id { get; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public int Value { get; set; }
        public Mark(int Id, int StudentID, int SubjectID, int Value)
        {
            this.Id = Id;
            this.StudentID = StudentID;
            this.SubjectID = SubjectID;
            this.Value = Value;
        }
    }
}
