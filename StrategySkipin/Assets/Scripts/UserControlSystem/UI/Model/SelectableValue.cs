using System;
using Abstractions;
using UnityEngine;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
    public class SelectableValue : ScriptableObjectBase<ISelectable>
    {
        //public ISelectable CurrentValue { get; private set; }
        //public Action<ISelectable> OnNewValue;

        //public void SetValue(ISelectable value)
        //{
        //    CurrentValue = value;
        //    OnNewValue?.Invoke(value);
        //}
    }
}

