using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Core
{
    public sealed class MainBuilding : MonoBehaviour, ISelectable, IAttackable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;
        public Transform StartPoint => _startPoint;

        [SerializeField] private Transform _unitsParent;
        [SerializeField] private Transform _startPoint;
        [SerializeField] private float _maxHealth = 1000;
        [SerializeField] private Sprite _icon;

        private float _health = 1000;

        //public override  Task ExecuteSpecificCommand(IProduceUnitCommand command)
        //{
        //    Debug.Log("Unit");
        //    //Instantiate(command.UnitPrefab, new Vector3(Random.Range(-10, 10), 0,
        //    //Random.Range(-10, 10)), Quaternion.identity, _unitsParent);
        //}

    }
}