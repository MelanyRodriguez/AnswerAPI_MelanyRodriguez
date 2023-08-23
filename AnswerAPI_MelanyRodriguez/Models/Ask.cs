using System;
using System.Collections.Generic;

namespace AnswerAPI_MelanyRodriguez.Models
{
    public partial class Ask
    {
        public Ask()
        {
            Answers = new HashSet<Answer>();
        }

        public long AskId { get; set; }
        public string Date { get; set; }
        public string Ask1 { get; set; } = null!;
        public int UserId { get; set; }
        public int AskStatusId { get; set; }
        public bool? IsStrike { get; set; }
        public string? ImageUrl { get; set; }
        public string? AskDetail { get; set; }

        public virtual AskStatus AskStatus { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
