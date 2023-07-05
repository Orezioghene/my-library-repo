﻿namespace thelibrary.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //books

        public ICollection<Book> Books { get; set; }
    }
}

