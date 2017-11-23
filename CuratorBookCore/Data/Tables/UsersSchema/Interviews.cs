using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class Interviews
    {
        [Key]
        public int Id { get; set; }


        public int UserId { get; set; }

        [ForeignKey("UserId")]
        protected Users User { get; set; }
    }
}
