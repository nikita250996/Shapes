using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    /// <summary>
    /// Главный код квадрата
    /// </summary>
    public class Cube : Shape, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            if (this == Player.SelectedShape)
            {
                return;
            }

            Player.SelectedShape = this;
        }
    }
}