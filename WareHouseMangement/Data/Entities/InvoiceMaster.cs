using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseMangement.Data.Entities
{
    public class InvoiceMaster
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 DocumentTypeId { get; set; }
        [ForeignKey("DocumentTypeId")]
        public DocumentType DocumentType { get; set; }

        public DateTime SysInvoiceNumber { get; set; }
        public DateTime CInvoiceNumber { get; set; }
        public DateTime Date { get; set; }

        public float TotalCost { get; set; }
        public float TotalPaid { get; set; }
        public bool IsTotalPaid
        {
            get; set;
        }
        public Int64? StoreID { get; set; }
        [ForeignKey("StoreID")]
        public Store Store { get; set; }

        public Int64? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public DateTime DueDate { get; set; } = DateTime.Now;
        public Int64? SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

        public string Notes { get; set; }
        public bool IsActive { get; set; } = false;
    }
}
