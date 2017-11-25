using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuratorBookCore.Data.Tables
{
    public enum RolesEn
    {
        Guest = 1,
        Student = 2,
        Curator = 3,
        Checker = 4,
        Admin = 5,
        Deanery = 6,
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
