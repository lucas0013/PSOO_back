namespace lojaGeekAPI.Models
{
    public class Carrinho
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Status { get; set; }
        public int? usuarioId { get; set; }
        public List<Produto>? Produtos { get; set; }
    }
}
