using UnityEngine;
using UnityEngine.AI;

namespace Movement
{
    public class ControlMovement : MonoBehaviour
    {
        public float Speed;
        public float BaseMovePoints;

        public NavMeshAgent NavAgent;

        private float currentMovePoints;

        void Start() => ResetMovePoints();
        
        public void Move(Vector2 moveVector)
        {
            if (currentMovePoints > 0)
            {
                //Translate(moveVector);
                Navigate(moveVector);
            }
        }

        private void Translate(Vector2 moveVector)
        {
            var vector3d = new Vector3(moveVector.x, 0f, moveVector.y);
            NavAgent.Move(vector3d * Speed);

            currentMovePoints -= vector3d.magnitude * Speed;
        }

        private void Navigate(Vector2 moveVector)
        {
            var vector3d = new Vector3(moveVector.x, 0f, moveVector.y);
            NavAgent.SetDestination(transform.position + vector3d);
            NavAgent.isStopped = false;
            currentMovePoints -= vector3d.magnitude * Speed;
        }

        public void ResetMovePoints() => currentMovePoints = BaseMovePoints;
    }
}
