﻿using System.ComponentModel.DataAnnotations;
using thelibrary.Data.enums;

namespace thelibrary.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        
        //public string PictureURL { get; set; }
        public string Name { get; set; }
        public string? Biography { get; set; }
        public sex Sex { get; set; }

        //Relationship
        public ICollection<BookAuthor> BookAuthors { get; set; }

    }
}
