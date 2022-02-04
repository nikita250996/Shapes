using Assets.Scripts;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Expansion.Scripts
{
    /// <summary>
    /// ��� ����� �� ���������� � ������������� �������������
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
            Shape selectedShape = _player.SelectedShape; // ������, �� ������� �������� ������
            // ���� �� ����� ����� ������ ������������ � ��� ����� ������ ������������
            if (selectedShape != null && selectedShape.GetComponent<Triangle>() != null)
            {
                _player.SelectedShape = null;
            }
        }
    }
}