using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class PagesRights
    {
        [Key]
        public int Id { get; set; }
        
        [Index("PageRightIndex", IsUnique = true)]
        public int PageId { get; set; }

        [ForeignKey("PageId")]
        private Pages Page { get; set; }


        [Index("PageRightIndex", IsUnique = true)]
        public int RightId { get; set; }

        [ForeignKey("RightId")]
        public Rights Right { get; set; }
    }
}
