class Order
{
    private List<Product> _products { get; }
    public Customer _customer { get; }

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in _products)
        {
            totalPrice += product.GetTotalCost();
        }
        return totalPrice + (_customer.IsInUSA() ? 5 : 35); // Shipping cost
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product._name} (ID: {product._productId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer._name}\n{_customer._address}";
    }
}