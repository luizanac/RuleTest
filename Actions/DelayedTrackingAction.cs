using RulesEngine.Actions;
using RulesEngine.Models;

namespace RuleTest;

public class DelayedTrackingAction : ActionBase
{
    public override ValueTask<object> Run(ActionContext context, RuleParameter[] ruleParameters)
    {
        var pedido = (Pedido)ruleParameters.First(x => x.Name == "pedido").Value;
        Console.WriteLine($"Contabilizando tracking atrasado para o pedido {pedido.IdPedido}");
        return ValueTask.FromResult<object>(0);
    }
}