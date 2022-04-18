using Abstractions.Commands.CommandsInterfaces;
using System.Threading.Tasks;
using UnityEngine;

public class PatrolCommandExecutor : CommandExecutorBase<IPatrolCommand>
{
    public override async Task  ExecuteSpecificCommand(IPatrolCommand command)
    {
        Debug.Log("Patrol!");
    }
}
