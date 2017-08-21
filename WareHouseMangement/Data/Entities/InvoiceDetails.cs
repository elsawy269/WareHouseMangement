using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseMangement.Data.Entities
{
    public class InvoiceDetails
    {



        [Key]
        public Int64 Id { get; set; }
        public Int64 MasterId { get; set; }
        [ForeignKey("MasterId")]
        public InvoiceMaster Master { get; set; }
        public Int64 ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Int64 Item { get; set; }

        public float Qty { get; set; }
        public float PurchasePrice { get; set; }
        public float SalesPrice { get; set; }

        public string Notes { get; set; }
        public bool IsActive { get; set; } = false;


    }
}
