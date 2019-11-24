using Forum.Models;
using System.Linq;

namespace Forum.Interfaces
{
    public interface ITopicRepository
    {
        IQueryable<Topic> Topics { get; }
    }
}
