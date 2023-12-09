class Order
{
    private List<Product> _productList;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _productList = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in _productList)
        {
            totalPrice += product.GetTotalPrice();
        }

        totalPrice += _customer.IsUSA() ? 5 : 35;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _productList)
        {
            packingLabel += product.GetPackingLabel() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetShippingLabel();
    }
}