using LearningAPI.Models;

namespace LearningAPI.Interface
{
	public interface ICardInterface
	{
		List<Card> GetAll();
		Card GetById(Guid id);
		Card Add(Card card);
		Card Update(Card card);
		void Delete(Guid id);
	}
}
