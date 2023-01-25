using LearningAPI.DataLayer;
using LearningAPI.Interface;
using LearningAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningAPI.Repo
{
	public class CardRepo : ICardInterface
	{
		private readonly DataContext _dataContext;

		public CardRepo(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public Task<Card> Add(Card card)
		{
			_dataContext.Cards.Add(card);
			_dataContext.SaveChanges();
			return Task.FromResult(card);
		}

		public void Delete(Guid id)
		{
			var card = _dataContext.Cards.FirstOrDefault(p => p.Id == id);
			_dataContext.Cards.Remove(card);
			_dataContext.SaveChanges();
		}

		public Task<List<Card>> GetAll() => _dataContext.Cards.ToListAsync();

		public Task<Card> GetById(Guid id)
		{
			var card = _dataContext.Cards.FirstOrDefault(p => p.Id == id);
			return Task.FromResult(card);
		}

		public Task<Card> Update(Card card)
		{
			_dataContext.Cards.Update(card);
			_dataContext.SaveChanges();
			return Task.FromResult(card);
		}
	}
}
