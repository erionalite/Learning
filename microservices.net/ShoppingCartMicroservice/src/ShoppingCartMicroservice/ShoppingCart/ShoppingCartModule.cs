using Nancy;
using Nancy.ModelBinding;
using Nancy.Routing;


namespace ShoppingCart.ShoppingCart
{
    public class ShoppingCartModule : NancyModule
    {
        public ShoppingCartModule(IShoppingCartStore shoppingCartStore,
            IProductcatalogClient productcatalog,
            IEventStore eventStore) : base("/shoppingcart")
        {
            Get["/{userid:int}"] = parameters =>
            {
                var userId = (int) parameters.userid;
                return shoppingCartStore.Get(userId);
            };
            Post["/{userid:int/items}", runAsync: true] = async (ParameterSegmentInformation, _) =>
            {
                var productcatalogIds = this.Bind<int[]>();
                var userId = (int) ParameterSegmentInformation.userid;
                var shoppingCart = shoppingCartStore.Get(userId);
                var shoppingCartItems = await productcatalog.GetShoppingCartItems(productcatalogIds);
                
                shoppingCart.AddItems(shoppingCartItems, eventStore);
                shoppingCart.Save(shoppingCart);
                return shoppingCart;
            };

            Delete["/{userid:int}/items"] = parameters =>
            {
                var productcatalogIds = this.Bind<int[]>();
                var userId = (int) parameters.id;
                var shoppingCart = shoppingCartStore.Get(userId);
                shoppingCart.RemoveItems(productcatalogIds, eventStore);
                shoppingCartStore.Save(shoppingCart);
                return shoppingCart;
            };
        }
    }
}

