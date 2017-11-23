using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class UsersRights
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        private Users User { get; set; }

        public int RightId { get; set; }

        [ForeignKey("RightId")]
        public Rights Right { get; set; }
    }
}
