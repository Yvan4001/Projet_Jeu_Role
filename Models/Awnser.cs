using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_Jeu_Role.Models
{
				public class Awnser
				{
								public int Id { get; set; }
								public string AwserContent { get; set; } = string.Empty;
								public int SituationIdEnter { get; set; }
								public int SituationIdExit { get; set; }
				}
}
