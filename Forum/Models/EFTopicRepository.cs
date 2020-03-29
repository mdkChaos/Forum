using Forum.Interfaces;
using System.Linq;

namespace Forum.Models
{
    public class EFTopicRepository : ITopicRepository
    {
        private ApplicationDbContext context;

        public EFTopicRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Topic> Topics => context.Topics;
    }
}
