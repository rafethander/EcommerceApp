
using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.EntityModels
{
    public class Shop : IDeletable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public int? DeletedById { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeleteRemarks { get; set; }

        //Fk
        public virtual ICollection<Product> Products { get; set; }
        public Shop()
        {
            Products = new List<Product>();
        }
    }
}
