using LearningAPI.Models;

namespace LearningAPI.Interface
{
	public interface ICardInterface
	{
		Task<List<Card>> GetAll();
		Task<Card> GetById(Guid id);
		Task<Card> Add(Card card);
		Task<Card> Update(Card card);
		void Delete(Guid id);
	}
}
