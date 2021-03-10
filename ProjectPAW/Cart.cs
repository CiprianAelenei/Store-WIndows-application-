using System;
using System.Collections.Generic;

namespace ProjectPAW
{
    public class Cart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public int Discount { get; set; }
        public int Net { get; set; }
        public int SubTotal { get; set; }

        //si alte proprietati care tin de totalul cosului omului

        public Client Client { get; set; }
        internal void AddProduct(Product selectedProduct, int quantity)
        {
            Items.Add(new CartItem
            {
                Product = selectedProduct,
                Quantity = quantity,
            });
        }
    }
}
