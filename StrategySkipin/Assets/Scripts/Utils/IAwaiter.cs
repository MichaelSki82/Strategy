using System.Runtime.CompilerServices;
using UnityEngine;

namespace Utils
{
    public interface IAwaiter<TAwaited> : INotifyCompletion
    {
        bool IsCompleted { get; }
        TAwaited GetResult();
    }
}
