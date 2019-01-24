using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AI
{
    public class ActiveSpots : MonoBehaviour
    {
        public IEnumerable<Transform> GetSpots => GetComponentsInChildren<Transform>().Where(t => t != transform);
    }
}
