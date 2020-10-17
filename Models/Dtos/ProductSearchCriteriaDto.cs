using Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dtos
{
    public class ProductSearchCriteriaDto
    {
        public string Name { get; set; }

        public string Code { get; set; }
        public double FromSalePrice { get; set; }
        public double ToSalePrice { get; set; }


        //Fk
        public int ShopId { get; set; }
        public Shop Shop { get; set; }

    }
}
