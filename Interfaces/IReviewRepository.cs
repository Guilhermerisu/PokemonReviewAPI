using C_Comfy.Models;

namespace C_Comfy.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);
        bool ReviewExists(int reviewId);   
        bool CreateReview(Review review);
        bool Save();
    }
}
