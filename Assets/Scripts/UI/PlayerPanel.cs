using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class PlayerPanel : MonoBehaviour
    {
        public Image MovementFill;

        public void UpdateMovementPie(float value) => MovementFill.fillAmount = value;
    }
}
