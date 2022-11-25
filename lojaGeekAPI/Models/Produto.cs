namespace lojaGeekAPI.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? valor { get; set; }
        public int Estoque { get; set; }
        public int Status { get; set; }
        public int? CarrinhoId { get; set; }
    }
}
