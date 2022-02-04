using UnityEngine;

namespace Assets.Scripts
{
    public class LevelScreen : MonoBehaviour
    {
        private Player _player;
        private LevelMenu _levelMenu;

        private void Start()
        {
            _player = FindObjectOfType<Player>();
            _levelMenu = _player.LevelMenu;
            // ��� �������� �� ������� ����� �������� ������� �� ����
            _player.LevelScreen = this;
        }

        // � ��������� ��������� � ����� �� ������
        public void OpenMenu()
        {
            if (_levelMenu != null)
            {
                _levelMenu.gameObject.SetActive(true);
            }

            Destroy(gameObject);
        }
    }
}