using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseMangement.Data.Entities
{
    public class BaseEntity
    {
        [Key]
        public Int64 Id { get; set; }
        [Required()]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Required()]

        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public string UpdateBy { get; set; }
        public string CreateBy { get; set; }
        public bool IsActive { get; set; } = false;
        public string Notes { get; set; }
        [Required()]
        public string Name { get; set; }
        public string NameEn { get; set; }

        [Required()]
        public string code { get; set; }
    }
}
