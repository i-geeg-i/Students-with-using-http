using System;

namespace HTTP_APi
{
    public class SubjectType
    {
        public int Id { get; }
        public string Name { get; set; }
        public int NeedMarks { get; set; }
        public SubjectType(int Id, string Name, int NeedMarks)
        {
            this.Id = Id;
            this.Name = Name;
            this.NeedMarks = NeedMarks;
        }
    }
}
