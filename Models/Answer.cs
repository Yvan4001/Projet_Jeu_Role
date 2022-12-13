namespace Projet_Jeu_Role.Models
{
	public class Answer
	{
		public int Id { get; set; }
		public string AnswerContent { get; set; } = string.Empty;
		public int SituationIdEnter { get; set; }
		public int SituationIdExit { get; set; }
	}
}
