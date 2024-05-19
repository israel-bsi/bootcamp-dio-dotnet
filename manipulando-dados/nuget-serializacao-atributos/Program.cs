using Models;
using Newtonsoft.Json;

////Deserialização
var conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
var vendas = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

foreach (var venda in vendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data da Venda: {venda.DataVenda}");
}

////Serialização
// var vendas = new List<Vendas>
// {
//     new(1, "Material de escritório", 25.00m, DateTime.Now),
//     new(2, "Licença de Software", 110.00m, DateTime.Now)
// };

// var serializado = JsonConvert.SerializeObject(vendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);
// Console.WriteLine(serializado);