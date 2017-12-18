using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class RolesRights
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int RolesId { get; set; }

        [ForeignKey("RolesId")]
        public Roles Roles { get; set; }

        public int RightsId { get; set; }

        [ForeignKey("RightsId")]
        public Rights Rights { get; set; }


        public PermissionTypes Permission { get; set; }
    }
}
