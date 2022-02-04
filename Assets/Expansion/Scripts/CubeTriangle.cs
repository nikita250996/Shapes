using Assets.Scripts;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Expansion.Scripts
{
    /// <summary>
    /// Код квадрата из расширения — использование треугольников
    /// </summary>
    public class CubeTriangle : MonoBehaviour, IPointerClickHandler
    {
        private Player _player;
        private PlayerEnergyTriangle _playerEnergyTriangle;

        private void Start()
        {
            _player = FindObjectOfType<Player>();
            _playerEnergyTriangle = _player.GetComponent<PlayerEnergyTriangle>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Shape selectedShape = _player.SelectedShape; // Фигура, по которой кликнули раньше
            // Нам нужно, чтобы у игрока была энергия, перед кликом по квадрату был клик по треугольнику
            if (_playerEnergyTriangle == null || _playerEnergyTriangle.Value <= 0 || selectedShape == null ||
                selectedShape.GetComponent<Triangle>() == null)
            {
                return;
            }

            // Уменьшаем квадрат
            Cube cube = gameObject.GetComponent<Cube>();
            --cube.Size;
            cube.SetScale();

            // Треугольник пропадает с игрового поля
            Destroy(selectedShape.gameObject);

            _playerEnergyTriangle.SuccessfulAction();
        }
    }
}