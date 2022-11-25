namespace lojaGeekAPI.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public List<Produto>? Produtos { get; set; }

    }
}
