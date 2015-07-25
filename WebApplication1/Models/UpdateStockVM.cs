using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UpdateStockVM
    {
        public int ProductId { get; set; }
        public decimal Stock { get; set; }
    }
}