

namespace ShoppingCart.ShoppingCart
{
    public interface IShoppingCartStore
    {

        ShoppingCart Get(int userID);
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
    }
}
