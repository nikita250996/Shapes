using Assets.Scripts;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Expansion.Scripts
{
    /// <summary>
    /// ��� �������� �� ���������� � ������������� �������������
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
            Shape selectedShape = _player.SelectedShape; // ������, �� ������� �������� ������
            // ��� �����, ����� � ������ ���� �������, ����� ������ �� �������� ��� ���� �� ������������
            if (_playerEnergyTriangle == null || _playerEnergyTriangle.Value <= 0 || selectedShape == null ||
                selectedShape.GetComponent<Triangle>() == null)
            {
                return;
            }

            // ��������� �������
            Cube cube = gameObject.GetComponent<Cube>();
            --cube.Size;
            cube.SetScale();

            // ����������� ��������� � �������� ����
            Destroy(selectedShape.gameObject);

            _playerEnergyTriangle.SuccessfulAction();
        }
    }
}