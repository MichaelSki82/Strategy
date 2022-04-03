using System;
using Abstractions.Commands.CommandsInterfaces;
using Utils;
using UserControlSystem.CommandsRealization;
using Zenject;

namespace UserControlSystem
{
    public  class ProduceUnitCommandCommandCreator : CommandCreatorBase<IProduceUnitCommand>
    {
        [Inject] private AssetsContext _context;

        protected override void ClassSpecificCommandCreation(Action<IProduceUnitCommand> creationCallback)
            => creationCallback?.Invoke(_context.Inject(new ProduceUnitCommandHeir()));
    }
}