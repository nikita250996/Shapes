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
            // При переходе на уровень нужно сообщить профилю об этом
            _player.LevelScreen = this;
        }

        // В редакторе привязано к клику по кнопке
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