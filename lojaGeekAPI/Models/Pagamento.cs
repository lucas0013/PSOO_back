namespace lojaGeekAPI.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public string? Data { get; set; }
        public string? Valor { get; set; }
        public string? Hora { get; set; }
        public int pedidoId { get; set; }
    }
}
