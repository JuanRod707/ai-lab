using System;
using UnityEngine;
using UnityEngine.AI;

namespace Movement
{
    public class NavigatorMovement : MonoBehaviour
    {
        public NavMeshAgent NavAgent;
        public float ReachDistance;

        private Vector3 targetNavPoint;
        private Action onTargetReached;

        private bool TargetReached => Vector3.Distance(transform.position, targetNavPoint) < ReachDistance;

        public void MoveTo(Vector3 target, Action targetReachedCallback)
        {
            onTargetReached = targetReachedCallback;
            targetNavPoint = target;
            NavAgent.SetDestination(target);
        }

        public void Stop() => NavAgent.isStopped = true;

        public void Resume() => NavAgent.isStopped = false;

        void Update()
        {
            if (TargetReached)
                onTargetReached();
        }
    }
}
