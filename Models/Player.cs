namespace Projet_Jeu_Role.Models
{
	public class Player
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int UserId { get; set; }
		public int SituationId { get; set; }
	}
}
