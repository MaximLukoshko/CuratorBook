using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public enum ControlTypes
    {
        CtLine = 1,
        CtNumber = 2,
        CtCheckbox = 3,
        CtTextArrea = 4,
        CtDate = 5,
    }

    public class Controls
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
