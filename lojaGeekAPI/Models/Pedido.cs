namespace lojaGeekAPI.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Valor { get; set; }
        public int Status { get; set; }
        public List<ItemPedido>? ItemPedido { get; set; }
    }
}
