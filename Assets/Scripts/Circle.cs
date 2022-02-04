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
            Shape selectedShape = Player.SelectedShape; // Фигура, по которой кликнули раньше
            if (this == selectedShape)
            {
                return;
            }

            // Нас интересует только квадрат такого же размера
            if (selectedShape == null || selectedShape.GetComponent<Cube>() == null || selectedShape.Size != Size)
            {
                return;
            }

            // Помещаем квадрат в круг
            selectedShape.transform.SetParent(transform);
            selectedShape.transform.position = transform.position;

            // Запрещаем кликать по квадрату
            selectedShape.transform.GetChild(0).GetComponent<Image>().raycastTarget = false;

            if (_playerMoves != null)
            {
                _playerMoves.SuccessfulAction();
            }
        }
    }
}