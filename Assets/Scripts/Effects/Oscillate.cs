using UnityEngine;

namespace Effects
{
    public class Oscillate : MonoBehaviour
    {
        public float Frequency;
        public float Strength;

        private float angle;

        void Update()
        {
            angle += Frequency;
            var pos = transform.localPosition;
            pos.y = Mathf.Sin(angle) * Strength;

            transform.localPosition = pos;
        }
    }
}
