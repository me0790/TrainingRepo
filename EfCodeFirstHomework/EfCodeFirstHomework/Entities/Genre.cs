using System.Collections;
using System.Collections.Generic;

namespace EfCodeFirstHomework
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}