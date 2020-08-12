using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MTShop.DataLayer.Models.User;
namespace MTShop.DataLayer.Models.Product
{
    public class ProductRating
    {

        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int UserId { get; set; }

        public int Score { get; set; }

        #region Relations

        public virtual Product Product { get; set; }

        public User.User User { get; set; }
        #endregion

    }
}
