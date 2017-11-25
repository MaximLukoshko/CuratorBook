using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class Pages
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [StringLength(150)]
        public string Name { get; set; }


        public Rights Rights { get; set; }


        public ICollection<Forms> Forms { get; set; }
    }
}
