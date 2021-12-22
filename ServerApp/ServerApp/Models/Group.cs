using System;

namespace HTTP_APi
{
    public class Group
    {
        public string Id { get; }
        public int Curs { get; set; }
        public int Spec { get; set; }
        public int OldesStudentId { get; set; }
        public Group(int Id, int Curs, int Spec, int OldesStudentId)
        {
            this.Id = Id;
            this.Curs = Curs;
            this.Spec = Spec;
            this.OldesStudentId = OldesStudentId;
        }
    }
}
