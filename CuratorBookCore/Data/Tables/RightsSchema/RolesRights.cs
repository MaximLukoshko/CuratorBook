using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public class RolesRights
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int RolesId { get; set; }

        public int RightsId { get; set; }


        public PermissionTypes Permission { get; set; }
    }
}
