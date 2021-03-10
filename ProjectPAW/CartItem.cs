
namespace ProjectPAW
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return Quantity * Product.Price;
            }
            set
            {
                //o chestie ciudata la set
            }
        }
    }
}
