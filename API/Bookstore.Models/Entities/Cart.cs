namespace Bookstore.Models.Entities;

public class Cart
{

    private readonly Dictionary<Product, int> _products = [];

    public void AddProduct(Product product, int quantity)
    {
        if (!_products.TryAdd(product, quantity))
        {
            _products[product] += quantity;
        }
    }

    public void RemoveProduct(Product product, int quantity)
    {
        if (_products.ContainsKey(product))
        {
            _products[product] -= quantity;
            if (_products[product] <= 0)
            {
                _products.Remove(product);
            }
        }
    }

    public decimal GetTotal()
    {
        return _products.Sum(p => p.Key.Price * p.Value);
    }

    public void Clear()
    {
        _products.Clear();
    }

    public IEnumerable<(Product product, int quantity)> GetItems()
    {
        return _products.Select(p => (p.Key, p.Value));
    }
}
