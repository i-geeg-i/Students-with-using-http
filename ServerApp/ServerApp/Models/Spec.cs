using System;

namespace HTTP_APi
{
    public class Spec
    {
        public int Code { get; }
        public string Name { get; set; }
        public int Department { get; set; }
        public Spec(int Id, string Name, string Department)
        {
            this.Id = Id;
            this.Name = Name;
            this.Department = Department;
        }
    }
}
