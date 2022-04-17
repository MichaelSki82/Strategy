using Abstractions;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using UserControlSystem;
using UserControlSystem.UI.Model;
using Zenject;

public class UiModelInstaller : MonoInstaller
{
    [SerializeField] private Sprite _chomperSprite;
    public override void InstallBindings()
    {
        
        

        Container.Bind<CommandCreatorBase<IProduceUnitCommand>>()
            .To<ProduceUnitCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IMoveCommand>>()
            .To<MoveCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IAttackCommand>>()
            .To<AttackCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IStopCommand>>()
            .To<StopCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IPatrolCommand>>()
            .To<PatrolCommandCommandCreator>().AsTransient();

        Container.Bind<CommandButtonsModel>().AsTransient();
       

        Container.Bind<float>().WithId("ChomperFromMainBuilding").FromInstance(5f);
        Container.Bind<string>().WithId("ChomperFromMainBuilding").FromInstance("ChomperFromMainBuilding");
        Container.Bind<Sprite>().WithId("ChomperFromMainBuilding").FromInstance(_chomperSprite);
        Container.Bind<BottomCenterModel>().AsSingle();
    }
}