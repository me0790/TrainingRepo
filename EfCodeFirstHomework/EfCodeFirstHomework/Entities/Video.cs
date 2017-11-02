using System;
using System.Collections.Generic;

namespace EfCodeFirstHomework
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genres { get; set; }
        public Category Category { get; set; }
    }

    public enum Category
    {
        Silver = 1,
        Gold = 2,
        Platinum = 3
    }
}