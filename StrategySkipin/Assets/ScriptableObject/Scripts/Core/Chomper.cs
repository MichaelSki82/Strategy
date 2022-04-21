using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

public class Chomper : MonoBehaviour, ISelectable, IAttackable, IUnit, IDamageDealer
   
{
    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private Sprite _icon;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Animator _animator;
    [SerializeField] private StopCommandExecutor _stopCommand;
    [SerializeField] private int _damage = 25;

    public int Damage => _damage;
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;

    public Transform StartPoint => _startPoint;

       
    private float _health = 100;

    public void RecieveDamage(int amount)
    {
        if (_health <= 0)
        {
            return;
        }
        _health -= amount;
        if (_health <= 0)
        {
            _animator.SetTrigger("PlayDead");
            Invoke(nameof(destroy), 1f);
        }
    }

    private async void destroy()
    {
        await _stopCommand.ExecuteSpecificCommand(new StopCommand());
        Destroy(gameObject);
    }
}
