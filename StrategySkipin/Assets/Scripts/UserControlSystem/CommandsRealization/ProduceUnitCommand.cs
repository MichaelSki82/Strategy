using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Utils;
using Zenject;

namespace UserControlSystem.CommandsRealization
{
    public class ProduceUnitCommand : IProduceUnitCommand
    {
        public GameObject UnitPrefab => _unitPrefab;
        [InjectAsset("ChomperFromMainBuilding")] private GameObject _unitPrefab;
        [Inject(Id = "ChomperFromMainBuilding")] public string UnitName { get; }
        [Inject(Id = "ChomperFromMainBuilding")] public Sprite Icon { get; } 
        [Inject(Id = "ChomperFromMainBuilding")] public float ProductionTime { get; }

    }
}