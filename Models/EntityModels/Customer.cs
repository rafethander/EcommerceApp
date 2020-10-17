using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.EntityModels
{
    public class Customer:IDeletable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn  { get; set; }
        public string DeleteRemarks { get; set; }
        public int? DeletedById { get; set; }
    }
}
