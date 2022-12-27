using System.Text.Json.Serialization;

namespace RuleTest;

public class Destinatario
{

    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("endereco")]
    public Endereco Endereco { get; set; }
}

public class Endereco
{
    [JsonPropertyName("uf")]
    public string Uf { get; set; }
}


public class Pedido
{
    [JsonPropertyName("idPedido")]
    public int IdPedido { get; set; }

    [JsonPropertyName("valorTotal")]
    public double ValorTotal { get; set; }

    [JsonPropertyName("destinatario")]
    public Destinatario Destinatario { get; set; }

}
