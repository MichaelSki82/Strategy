using UnityEngine;

namespace Abstractions
{
    public interface ISelectable: IHealthKeeper
    {
        
        Sprite Icon { get; }
        Transform StartPoint { get; }
    }
}