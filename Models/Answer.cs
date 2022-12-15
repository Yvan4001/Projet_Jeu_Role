using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_Jeu_Role.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerContent { get; set; } = string.Empty;

        public int SituationEnterId { get; set; }
        public virtual Situation? SituationEnter { get; set; }

        public int? SituationExitId { get; set; }
        public virtual Situation? SituationExit { get; set; }

        public override string ToString()
        {
            return AnswerContent;
        }
    }
}
