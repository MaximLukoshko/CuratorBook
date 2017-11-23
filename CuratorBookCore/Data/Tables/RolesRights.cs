using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class RolesRights
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        private Roles Role { get; set; }

        public int RightId { get; set; }

        [ForeignKey("RightId")]
        public Rights Right { get; set; }


        public PermissionTypes Permission { get; set; }
    }
}
