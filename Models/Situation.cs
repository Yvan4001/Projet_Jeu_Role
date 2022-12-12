namespace Projet_Jeu_Role.Models
{
				public class Situation
				{
								public int Id { get; set; }
								public string SituationName { get; set; } = string.Empty;
								public string SituationDescription { get; set; } = string.Empty;
								public List<Answer> Awnsers { get; set; } = new List<Answer>();
				}
}
