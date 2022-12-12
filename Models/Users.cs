namespace Projet_Jeu_Role.Models
{
				public enum UserRole
				{
								Admin,
								Player
				}

				public class Users
				{
								public int Id { get; set; }
								public string Nom { get; set; } = String.Empty;
								public string Email { get; set; } = string.Empty;
								public string Password { get; set; } = string.Empty;
								public UserRole Role { get; set; }
				}
}
