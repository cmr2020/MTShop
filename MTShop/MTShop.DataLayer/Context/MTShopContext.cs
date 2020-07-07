using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MTShop.DataLayer.Context
{
   public class MTShopContext:DbContext
   {

       public MTShopContext(DbContextOptions<MTShopContext> options):base(options)
        {
            
        }

        #region User



        #endregion

        #region Product

        

        #endregion


    }
}
