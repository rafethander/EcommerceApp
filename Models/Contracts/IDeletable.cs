using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Contracts
{
    public interface IDeletable
    {
        bool IsDeleted { get; set; }
        int? DeletedById { get; set; }
        DateTime? DeletedOn { get; set; }
        string DeleteRemarks { get; set; }


    }
}
