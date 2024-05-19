using Newtonsoft.Json;

namespace Models;

public class Vendas
{
    public Vendas(int id, string produto, decimal preco, DateTime dataVenda)
    {
        Id = id;
        Produto = produto;
        Preco = preco;
        DataVenda = dataVenda;
    }
    public int Id { get; set; }
    [JsonProperty("Nome_Produto")]
    public string? Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }
}