namespace Domain.Dtos;

public class Orders
{
    public int Id { get; set; }
    public int productid { get; set; }
    public int customerid { get; set; }
    public DateTime createdat { get; set; }
    public int productcount { get; set; }
    public int price { get; set; }
}
