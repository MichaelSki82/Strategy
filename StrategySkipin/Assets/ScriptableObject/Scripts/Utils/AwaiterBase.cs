using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Utils
{
    public abstract class AwaiterBase<TAwaited> : IAwaiter<TAwaited>
    {
        private bool _isCompleted;
        private Action _continuation;
        private TAwaited _result;

        public TAwaited GetResult() => _result;

        public bool IsCompleted => _isCompleted;

        public void OnCompleted(Action continuation)
        {
            if (_isCompleted)
            {
                continuation?.Invoke();
            }
            else
            {
                _continuation = continuation;
            }
        }

        protected void OnWaitFinish(TAwaited result)
        {
            _result = result;
            _isCompleted = true;
            _continuation?.Invoke();
        }
    }

}

