using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperAttack : CommandExecutorBase<IAttackCommand>
{
    public override void ExecuteSpecificCommand(IAttackCommand command)
    {
        Debug.Log("Attack!");
    }
}
