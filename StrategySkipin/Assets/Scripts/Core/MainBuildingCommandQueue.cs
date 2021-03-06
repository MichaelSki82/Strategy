using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Zenject;

namespace Core
{
    public class MainBuildingCommandQueue : MonoBehaviour, ICommandsQueue
    {
        [Inject] CommandExecutorBase<IProduceUnitCommand> _produceUnitCommandExecutor;
        [Inject] CommandExecutorBase<ISetRallyPointCommand> _rallyPoint;
        public ICommand CurrentCommand => default;

        public void Clear() { }
        public async void EnqueueCommand (object command)
        {
            await _produceUnitCommandExecutor.TryExecuteCommand(command);
            await _rallyPoint.TryExecuteCommand(command);
        }

    }
}