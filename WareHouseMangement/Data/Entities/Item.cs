using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseMangement.Data.Entities
{
    public class Item: BaseEntity
    {
        
        public Int64 GroupId { get; set; }
        public Int64 UnitId { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; }
        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }



        //
        public DateTime ExpiryDate { get; set; }
        public float Weight { get; set; }


    }
}
