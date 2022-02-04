using Assets.Scripts;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Expansion.Scripts
{
    /// <summary>
    ///  од круга из расширени€ Ч использование треугольников
    /// </summary>
    public class CircleTriangle : MonoBehaviour, IPointerClickHandler
    {
        private Player _player;

        private void Start()
        {
            _player = FindObjectOfType<Player>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Shape selectedShape = _player.SelectedShape; // ‘игура, по которой кликнули раньше
            //  лик по кругу после выбора треугольника Ч это сброс выбора треугольника
            if (selectedShape != null && selectedShape.GetComponent<Triangle>() != null)
            {
                _player.SelectedShape = null;
            }
        }
    }
}