using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class Answers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int FormId { get; set; }

        [ForeignKey("FormId")]
        protected Forms Form { get; set; }


        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        protected Groups Group { get; set; }


        public string Value { get; set; }


        public bool IsFreezed { get; set; }


        public bool ISHidden { get; set; }
    }
}
