using Microsoft.EntityFrameworkCore;

namespace NwindMVC.Models
{
    public class RepositoryOrder
    {
        
        private readonly NorthwindContext _context;
        public RepositoryOrder(NorthwindContext context)
        {
            _context = context;
        }
        //public List<Order> AllOrders()
        //{
        //    return _context.Orders.ToList();
        //}
        public List<int> GetAllOrderId()
        {
            return _context.Orders.Select(order => order.OrderId).ToList();
        }
        public Order FindOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(order => order.OrderId == id);
        }
        public List<Order> FindOrderByCustomerID(string customerID)
        {
            return _context.Orders.Where(order => order.CustomerId == customerID).ToList();
        }
        public List<OrderDetail> FindOrderDetailByOrderId(int id)
        {
            List<Order> ordersWithOrderDetails = _context.Orders.Include(d => d.OrderDetails).ToList();   
            Order order = ordersWithOrderDetails.FirstOrDefault(x => x.OrderId == id);
            
            return order.OrderDetails.ToList();
        }
       // public List<OrderDetail> FindOrderDetailByOrderId(int id)
        public List<OrderDetail> FindOrderByOrderIdWithInclude(int id)
        {
            return _context.OrderDetails.Where(detail => detail.OrderId == id).ToList();
        }
        public Product GetProductById(int productId)
        {
            return _context.Products.FirstOrDefault(product => product.ProductId == productId);
        }
    }
}
