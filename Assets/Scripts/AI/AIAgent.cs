using Movement;
using UnityEngine;

namespace AI
{
    public class AIAgent : MonoBehaviour
    {
        public NavigatorMovement Movement;

        private ActiveSpots navigationPoints;
        
        public void Initialize(ActiveSpots navPoints)
        {
            navigationPoints = navPoints;
            SelectNewNavPoint();
        }

        void SelectNewNavPoint() => Movement.MoveTo(navigationPoints.GetSpots.PickOne().position, SelectNewNavPoint);
    }
}
