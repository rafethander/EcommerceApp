using System;
using System.Collections.Generic;
using System.Text;

namespace Models.EntityModels
{
    public class PurchaseOrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Remarks { get; set; }







        //Fk    
        public int OrderId { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }


        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
