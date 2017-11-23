using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class PagesRights
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int PageId { get; set; }

        [ForeignKey("PageId")]
        private Pages Page { get; set; }

        public int RightId { get; set; }

        [ForeignKey("RightId")]
        public Rights Right { get; set; }
    }
}
