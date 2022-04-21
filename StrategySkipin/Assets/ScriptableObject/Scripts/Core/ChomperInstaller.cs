using UnityEngine;
using Zenject;

public class ChomperInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IHealthKeeper>().FromComponentInChildren();
        Container.Bind<float>().WithId("AttackDistance").FromInstance(5f);
        Container.Bind<int>().WithId("AttackPeriod").FromInstance(1400);
    }
}