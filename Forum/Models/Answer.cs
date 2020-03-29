using Microsoft.AspNetCore.Identity;
using System;

namespace Forum.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public Topic Topic { get; set; }
        public string Body { get; set; }
        public DateTime Time { get; set; }
        public ApplicationUser User { get; set; }
    }
}
