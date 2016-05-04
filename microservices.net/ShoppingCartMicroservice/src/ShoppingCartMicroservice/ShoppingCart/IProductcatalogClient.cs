using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.ShoppingCart
{
    public interface IProductcatalogClient
    {
       Task<ShoppingCartItem> GetShoppingCartItems(int[] ids);
    }

    public class ProductcatalogClient : IProductcatalogClient
    {
        public async Task<ShoppingCartItem> GetShoppingCartItems(int[] ids)
        {
             await Task.Delay(1000).ConfigureAwait(false);
            return null;
        }
    }
}
