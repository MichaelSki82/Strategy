using Abstractions;
using System;
using UnityEngine;
using UserControlSystem;
using Utils;
using Zenject;

[CreateAssetMenu(fileName = "AssetInstaller", menuName = "Installers/AssetInstaller")]
public class AssetInstaller : ScriptableObjectInstaller<AssetInstaller>
{
    [SerializeField] private AssetsContext _legacyContext;
    [SerializeField] private Vector3Value _vector3Value;
    [SerializeField] private AttackableValue _attackableValue;
    [SerializeField] private SelectableValue _selectableValue;


    public override void InstallBindings()
    {
        Container.Bind<IAwaitable<IAttackable>>()
            .FromInstance(_attackableValue);
        Container.Bind<IAwaitable<Vector3>>()
            .FromInstance(_vector3Value);
        Container.BindInstances(_legacyContext, _selectableValue);
        Container.Bind<IObservable<ISelectable>>().FromInstance(_selectableValue);
    }
}