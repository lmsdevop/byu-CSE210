class Product
{
    public string _name { get; }
    public string _productId { get; }
    public decimal _price { get; }
    public int _quantity { get; }

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }
}