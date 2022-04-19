using UnityEngine;

namespace Core.CommandExecutors
{
    internal class MoveCommand
    {
        private Vector3 rallyPoint;

        public MoveCommand(Vector3 rallyPoint)
        {
            this.rallyPoint = rallyPoint;
        }
    }
}