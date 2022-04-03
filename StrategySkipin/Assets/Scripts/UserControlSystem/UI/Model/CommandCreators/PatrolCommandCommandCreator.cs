using System;
using Abstractions.Commands.CommandsInterfaces;
using Utils;
using UserControlSystem.CommandsRealization;
using Zenject;
using UnityEngine;

namespace UserControlSystem
{
    public class PatrolCommandCommandCreator : CommandCreatorBase<IPatrolCommand>
    {
        [Inject] private AssetsContext _context;
        [Inject] private SelectableValue _selectable;
        private Action<IPatrolCommand> _creationCallback;

        [Inject]
        private void Init(Vector3Value groundClicks)
        {
            groundClicks.OnNewValue += onNewValue;
        }

        private void onNewValue(Vector3 groundClick)
        {
            _creationCallback?.Invoke(_context.Inject(new
            PatrolCommand(_selectable.CurrentValue.StartPoint.position, groundClick)));
            _creationCallback = null;
        }


        protected override void ClassSpecificCommandCreation(Action<IPatrolCommand> creationCallback)
        {
            _creationCallback = creationCallback;
        }

        public override void ProcessCancel()
        {
            base.ProcessCancel();
            _creationCallback = null;
        }

    }
}