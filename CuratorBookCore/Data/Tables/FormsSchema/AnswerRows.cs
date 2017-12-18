using CuratorBookCore.Data.Tables.FormsSchema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class AnswerRows
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int FormId { get; set; }

        [ForeignKey("FormId")]
        public Forms Form { get; set; }


        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        public Groups Group { get; set; }


        public ICollection<AnswerValues> Answers { get; set; }


        public bool IsFreezed { get; set; }


        public bool ISHidden { get; set; }
    }
}
