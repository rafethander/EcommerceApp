using System;
using System.Collections.Generic;
using System.Text;

namespace Models.EntityModels
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string RefNo { get; set; }
        public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    }
}
