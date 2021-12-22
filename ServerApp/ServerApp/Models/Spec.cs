using System;

namespace HTTP_APi
{
    public class Spec
    {
        public string Code { get; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Spec(string Code, string Name, int DepartmentId)
        {
            this.Code = Code;
            this.Name = Name;
            this.DepartmentId = DepartmentId;
        }
    }
}
