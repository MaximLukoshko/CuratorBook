using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class FormsControls
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int ControlId { get; set; }

        [ForeignKey("ControlId")]
        public Controls Type { get; set; }


        public int FormId { get; set; }

        [ForeignKey("FormId")]
        private Forms Form { get; set; }


        [StringLength(50)]
        public string AnswerId { get; set; }
    }
}
