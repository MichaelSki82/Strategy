using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperMove : CommandExecutorBase<IMoveCommand>
{
    public override void ExecuteSpecificCommand(IMoveCommand command)
    {
        Debug.Log("Move!");
    }
}
