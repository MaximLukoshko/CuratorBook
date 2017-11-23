using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        public Groups Group { get; set; }


        [Required]
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Roles Role { get; set; }


        [StringLength(20)]
        public string Login { get; set; }

        [StringLength(20)]
        public string Password { get; set; }


        [StringLength(30)]
        public string Email { get; set; }
    }
}
