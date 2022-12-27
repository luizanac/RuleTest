#region Config

var pedidoJson = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Pedido.json"));
var pedido = JsonSerializer.Deserialize<Pedido>(pedidoJson);
var schemaJson = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "RuleSchema.json"));

var re = new RulesEngine.RulesEngine(new string[] { schemaJson }, new ReSettings());

#endregion

var input = new RuleParameter("pedido", pedido);
var result = await re.ExecuteAllRulesAsync("Discount", input);

foreach (var res in result.Where(x => x.IsSuccess))
{
    Console.WriteLine(res.Rule.RuleName);
}

result.OnSuccess((eventName) => Console.WriteLine($"O desconto oferecido é de {eventName}%."));

result.OnFail(() => Console.WriteLine("O pedido não está elegível para receber descontos."));