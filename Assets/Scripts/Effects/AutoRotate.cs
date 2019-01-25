using UnityEngine;

namespace Effects
{
    public class AutoRotate : MonoBehaviour
    {
        public float Speed;
        public Vector3 Axis;

        void Update() => transform.Rotate(Axis * Speed);
    }
}
