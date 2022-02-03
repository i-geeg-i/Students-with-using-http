using System;

namespace HTTP_APi
{
    public class Fakultet
    {
        public int Id { get; }
        public string Name { get; set; }
        public Fakultet(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
