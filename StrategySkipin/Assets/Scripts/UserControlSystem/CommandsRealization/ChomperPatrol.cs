using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperPatrol : CommandExecutorBase<IPatrolCommand>
{
    public override void ExecuteSpecificCommand(IPatrolCommand command)
    {
        Debug.Log("Patrol!");
    }
}
