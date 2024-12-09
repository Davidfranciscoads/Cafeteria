public class OrderItem
{
    public int Id { get; set;}
    public int OrderId { get; set; } // ID da ordem
    public int ProductId { get; set; } // ID do produto
    public int Quantity { get; set; } // Quantidade
}
