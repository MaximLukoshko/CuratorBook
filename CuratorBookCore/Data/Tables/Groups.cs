using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CuratorBookCore.Data.Tables
{
    public class Groups
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int Course { get; set; }


        public int SpecialityId { get; set; }
        [ForeignKey("SpecialityId")]
        public Specialities Speciality { get; set; }


        [StringLength(10)]
        public string GroupCode { get; set; }
    }
}
