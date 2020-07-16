using System;
using System.Collections.Generic;
using System.Text;

namespace MTShop.Core.DTOs
{
    public class ShowProductInBoxViewModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public bool IsExist { get; set; }

        public decimal Price { get; set; }

        public string ImageName { get; set; }



    }
}
