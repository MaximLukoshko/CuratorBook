using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public enum RolesEn
    {
        Guest = 1,
    }

    public class Roles
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [StringLength(15)]
        public string Name { get; set; }


        public List<RolesRights> RolesRights { get; set; }
    }
}
