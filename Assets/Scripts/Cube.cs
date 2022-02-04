using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    /// <summary>
    /// ������� ��� ��������
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