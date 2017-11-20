using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using brightideas.Models;

namespace brightideas.Models {
    public class Post : BaseEntity {
        [Key]
        public int PostId { get; set; }
        [MinLength(3)]
        public string Content { get; set; }

        public int UserId { get; set; }
        public User Poster { get; set; }

        public List<Like> Likes { get; set; }
        public Post() {
            Likes = new List<Like>();
        }
    }
}