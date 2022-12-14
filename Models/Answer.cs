using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_Jeu_Role.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerContent { get; set; } = string.Empty;
        [ForeignKey("SituationEnterId")]
        public int SituationEnterId { get; set; }


        [ForeignKey("SituationExitId")]
        public int SituationExitId { get; set; }
        public virtual Situation? Situation { get; set; }

        public override string ToString()
        {
            return AnswerContent;
        }
    }
}
