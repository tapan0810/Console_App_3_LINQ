namespace Console_App_3_LINQ.Models;

public class Order
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public decimal Amount { get; set; }

    public DateTime OrderDate { get; set; }
}