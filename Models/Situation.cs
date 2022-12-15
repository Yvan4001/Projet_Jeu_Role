namespace Projet_Jeu_Role.Models
{
    public class Situation
    {
        public int Id { get; set; }
        public string SituationName { get; set; } = string.Empty;
        public string SituationDescription { get; set; } = string.Empty;
        //public List<Answer> Answers { get; set; } = new List<Answer>();

        public virtual List<Answer> AnswerEnter { get; set; } = new List<Answer>();
        public virtual List<Answer> AnswerExit { get; set; } = new List<Answer>();


    }
}
