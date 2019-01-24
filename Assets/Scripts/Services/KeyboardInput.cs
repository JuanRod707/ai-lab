using Movement;
using UnityEngine;

namespace Services
{
    public class KeyboardInput : MonoBehaviour
    {
        public ControlMovement ControlMovement;

        void Update()
        {
            var movementVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            ControlMovement.Move(movementVector);
        }
    }
}
