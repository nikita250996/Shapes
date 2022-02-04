using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Circle : Shape, IPointerClickHandler
    {
        private PlayerMoves _playerMoves;

        private void Start()
        {
            _playerMoves = Player.GetComponent<PlayerMoves>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Shape selectedShape = Player.SelectedShape; // ������, �� ������� �������� ������
            if (this == selectedShape)
            {
                return;
            }

            // ��� ���������� ������ ������� ������ �� �������
            if (selectedShape == null || selectedShape.GetComponent<Cube>() == null || selectedShape.Size != Size)
            {
                return;
            }

            // �������� ������� � ����
            selectedShape.transform.SetParent(transform);
            selectedShape.transform.position = transform.position;

            // ��������� ������� �� ��������
            selectedShape.transform.GetChild(0).GetComponent<Image>().raycastTarget = false;

            if (_playerMoves != null)
            {
                _playerMoves.SuccessfulAction();
            }
        }
    }
}