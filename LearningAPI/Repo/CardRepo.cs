using LearningAPI.DataLayer;
using LearningAPI.Interface;
using LearningAPI.Models;

namespace LearningAPI.Repo
{
	public class CardRepo : ICardInterface
	{
		private readonly DataContext _dataContext;

		public CardRepo(DataContext dataContext)
		{
			_dataContext = dataContext;
		}
		public Card Add(Card card)
		{
			_dataContext.Cards.Add(card);
			_dataContext.SaveChanges();
			return card;
		}

		public void Delete(Guid id)
		{
			var card = _dataContext.Cards.FirstOrDefault(p => p.Id == id);
			_dataContext.Cards.Remove(card);
			_dataContext.SaveChanges();
		}

		public List<Card> GetAll() => _dataContext.Cards.ToList();

		public Card GetById(Guid id)
		{
			var card = _dataContext.Cards.FirstOrDefault(p => p.Id == id);
			return card;
		}

		public Card Update(Card card)
		{
			_dataContext.Cards.Update(card);
			_dataContext.SaveChanges();
			return card;
		}
	}
}
