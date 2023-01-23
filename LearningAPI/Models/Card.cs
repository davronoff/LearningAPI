using System.ComponentModel.DataAnnotations;

namespace LearningAPI.Models
{
	public class Card
	{
		[Required, Key]
		public Guid Id { get; set; }
		[Required, MinLength(2)]
		public string? Name { get; set; }
		[Required, MaxLength(50)]
		public string? Type { get; set; }
	}
}
