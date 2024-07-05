using DoAn_HoangDucLuu.Models;
using System.Collections.Generic;
using System.Linq;

namespace DoAn_HoangDucLuu.Services
{
    public class CartService
    {
        private readonly ApplicationDbContext _context;

        public CartService(ApplicationDbContext context)
        {
            _context = context;
        }

        private List<CartItem> cartItems = new List<CartItem>();

        public void AddToCart(CartItem item)
        {
            cartItems.Add(item);
        }

        public void RemoveFromCart(CartItem item)
        {
            cartItems.Remove(item);
        }

        public List<CartItem> GetCartItems()
        {
            return cartItems;
        }

        public void ClearCart()
        {
            cartItems.Clear();
        }

        public decimal GetTotalPrice()
        {
            return cartItems.Sum(item => item.Product.GiaSP * item.Quantity);
        }

        public int GetTotalQuantity()
        {
            return cartItems.Sum(item => item.Quantity);
        }

        public List<SanPham> SearchProducts(string searchQuery)
        {
            return _context.SanPhams
                           .Where(sp => sp.TenSP.Contains(searchQuery))
                           .ToList();
        }
    }
}
