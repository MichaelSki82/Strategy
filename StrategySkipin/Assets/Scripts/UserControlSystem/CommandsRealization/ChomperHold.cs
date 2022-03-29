using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperHold : CommandExecutorBase<IStopCommand>
{
   
    public override void ExecuteSpecificCommand(IStopCommand command)
    {
        Debug.Log("Stop");
    }
}
