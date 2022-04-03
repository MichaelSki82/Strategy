using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommandExecutor : CommandExecutorBase<IMoveCommand>
{
    public override void ExecuteSpecificCommand(IMoveCommand command)
    {
        Debug.Log($"{name} is moving ti {command.Target}!");
    }
}