using UnityEngine;

namespace Abstractions
{
    public interface ISelectable: IHealthKeeper, IIconHolder
    {
        
        
        Transform StartPoint { get; }
    }
}