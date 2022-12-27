using RulesEngine.Actions;
using RulesEngine.Models;

namespace RuleTest;

public class SendEmailAction : ActionBase
{
    public override async ValueTask<object> Run(ActionContext context, RuleParameter[] ruleParameters)
    {
        var template = context.GetContext<string>("template");
        var pedido = (Pedido)ruleParameters.First(x => x.Name == "pedido").Value;
        Console.WriteLine($"Enviando e-mail Pedido: {pedido.IdPedido} Template: {template} ");
        await Task.Delay(300);
        Console.WriteLine($"E-mail enviado Pedido: {pedido.IdPedido}");

        return ValueTask.FromResult<object>(0);
    }
}