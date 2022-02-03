using System;

namespace HTTP_APi
{
    public class Department
    {
        public int Id { get; }
        public string Name { get; set; }
        public int ZavId { get; set; }
        public int FakultetId { get; set; }
        public Department(int Id, string Name, int ZavId, int FakultetId)
        {
            this.Id = Id;
            this.Name = Name;
            this.ZavId = ZavId;
            this.FakultetId = FakultetId;
        }
    }
}
