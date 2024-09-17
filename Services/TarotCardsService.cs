using WebTarotReadings.Models;

namespace WebTarotReadings.Services
{
	public class TarotCardsService
	{
		public readonly AppDbContext _context;
		public TarotCardsService(AppDbContext context)
		{
			_context = context;
		}

		public TarotCardsModel GetTarotCard(int cardId)
		{
			return _context.TarotCards.FirstOrDefault(s => s.Id == cardId);
		}
	}
}
