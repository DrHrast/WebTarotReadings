namespace WebTarotReadings.Models
{
	public class TarotCardsModel
	{
		public int CardId { get; set; }
		public string CardName { get; set; }
		public bool IsFlipped { get; set; }
		public string CardText { get; set; }
	}
}
