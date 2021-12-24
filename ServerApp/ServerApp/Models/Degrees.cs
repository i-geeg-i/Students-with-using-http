using System;

namespace HTTP_APi
{
    public class Degrees
    {
        public int Id { get; }
        public string Name { get; set; }
        public Degrees(int id, string Name)
        {
            this.Id = id;
            this.Name = Name;
        }
    }
}
