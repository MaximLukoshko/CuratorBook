using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public enum ControlTypes
    {
        InputString,
        Number,
        Checkbox,
        TextArrea,
    }

    public class Controls
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public ControlTypes Type { get; set; }
    }
}
