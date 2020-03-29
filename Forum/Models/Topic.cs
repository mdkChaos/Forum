using Microsoft.AspNetCore.Identity;
using System;

namespace Forum.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Time { get; set; }
        public Theme Theme { get; set; }
        public ApplicationUser User { get; set; }
    }
}
