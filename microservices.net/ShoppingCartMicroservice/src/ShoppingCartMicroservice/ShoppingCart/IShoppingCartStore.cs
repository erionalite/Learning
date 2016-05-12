

namespace ShoppingCart.ShoppingCart
{
    public interface IShoppingCartStore
    {

        ShoppingCart Get(int userID);
        void Save(ShoppingCart shoppingCart);
    }

    public class ShoppingCartItem
    {
    }

    public class ShoppingCart
    {
        public ShoppingCart AddItems(ShoppingCartItem item, IEventStore eventStore)
        {
            return null;
        }

        public void RemoveItems(int[] productcatalogIds, IEventStore eventStore)
        {

        }

        public void Save(ShoppingCart cart)
        {
        }
    }

    public class ShoppingCartStore : IShoppingCartStore
    {
        public ShoppingCart Get(int userID)
        {
            return null;
        }

        public void Save(ShoppingCart shoppingCart)
        {
            
        }

    }
}
