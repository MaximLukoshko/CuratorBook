using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables.FormsSchema
{
    public class AnswerValues
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int AnswerRowsId { get; set; }

        [ForeignKey("AnswerRowsId")]
        public AnswerRows Row { get; set; }

        public int ControlId { get; set; }

        [ForeignKey("ControlId")]
        public FormsControls Control { get; set; }

        public string Value { get; set; }
    }
}
