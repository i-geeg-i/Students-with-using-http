using System;

namespace HTTP_APi
{
    public class Post
    {
        public int Id { get; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Group { get; set; }
        public Post(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
