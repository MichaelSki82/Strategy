using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System;
using UnityEngine;
using Zenject;

namespace UserControlSystem
{
    public sealed class CommandButtonsModel
    {
        public event Action<ICommandExecutor> OnCommandAccepted;
        public event Action OnCommandSent;
        public event Action OnCommandCancel;

        [Inject] private CommandCreatorBase<IProduceUnitCommand> _unitProducer;
        [Inject] private CommandCreatorBase<IMoveCommand> _mover;
        [Inject] private CommandCreatorBase<IAttackCommand> _attacker;
        [Inject] private CommandCreatorBase<IStopCommand> _stopper;
        [Inject] private CommandCreatorBase<IPatrolCommand> _patroller;
        [Inject] private CommandCreatorBase<ISetRallyPointCommand> _rallyPoint;

        private bool _commandIsPending;

        public void OnCommandButtonClicked(ICommandExecutor commandExecutor,ICommandsQueue commandsQueue)
        {
            if (_commandIsPending)
            {
                processOnCancel();
            }
            _commandIsPending = true;
            OnCommandAccepted?.Invoke(commandExecutor);
            _unitProducer.ProcessCommandExecutor(commandExecutor, command => executeCommandWrapper(command, commandsQueue));
            _attacker.ProcessCommandExecutor(commandExecutor, command => executeCommandWrapper(command, commandsQueue));
            _stopper.ProcessCommandExecutor(commandExecutor, command => executeCommandWrapper(command, commandsQueue));
            _mover.ProcessCommandExecutor(commandExecutor, command => executeCommandWrapper(command, commandsQueue));
            _patroller.ProcessCommandExecutor(commandExecutor, command => executeCommandWrapper(command, commandsQueue));
            _rallyPoint.ProcessCommandExecutor(commandExecutor, command => executeCommandWrapper(command, commandsQueue));
        }


        public void executeCommandWrapper(object command, ICommandsQueue commandsQueue)
        {
            if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
            {
                commandsQueue.Clear();
            }
            commandsQueue.EnqueueCommand(command);
            _commandIsPending = false;
            OnCommandSent?.Invoke();
        }


        public void OnSelectionChanged()
        {
            _commandIsPending = false;
            processOnCancel();
        }

        private void processOnCancel()
        {
            _unitProducer.ProcessCancel();
            _mover.ProcessCancel();
            _attacker.ProcessCancel();
            _stopper.ProcessCancel();
            _patroller.ProcessCancel();
            _rallyPoint.ProcessCancel();
            OnCommandCancel?.Invoke();
        }
    }
}