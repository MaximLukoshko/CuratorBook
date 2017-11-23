using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class Forms
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int PageId { get; set; }

        [ForeignKey("PageId")]
        public Pages Page { get; set; }


        [StringLength(150)]
        public string Name { get; set; }


        public ICollection<FormsControls> Controls { get; set; }
    }
}
