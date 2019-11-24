using Forum.Models;
using System.Linq;

namespace Forum.Interfaces
{
    public interface IAnswerRepository
    {
        IQueryable<Answer> Answers { get; }
    }
}
