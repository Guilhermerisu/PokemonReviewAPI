using C_Comfy.Models;

namespace C_Comfy.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();

        Reviewer GetReviewer(int reviewerId);

        ICollection<Reviewer> GetReviewByReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);
        bool CreateReviewer(Reviewer reviewer);
        bool UpdateReviewer(Reviewer reviewer); 
        bool Save();
    }
}
