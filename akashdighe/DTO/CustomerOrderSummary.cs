namespace akashdighe.DTO;
public class CustomerOrderSummary
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string Country { get; set; }
    public int TotalOrders { get; set; }
    public decimal TotalAmount { get; set; }
}
