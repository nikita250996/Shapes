using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Для каждого параметра профиля нужны обработчики, которые будут реагировать на действия игрока и сообщать об этом интерфейсу
    /// </summary>
    public abstract class PlayerParameter : MonoBehaviour
    {
        internal Player Player;
        internal LevelScreen LevelScreen;
        internal LevelScreenText LevelScreenText;
        internal virtual int Value { get; set; }

        private void Awake()
        {
            Player = GetComponent<Player>();
        }

        public virtual void SuccessfulAction()
        {
            // После открытия уровня игрок об этом узнает сразу, а параметру нужно сообщить в случае необходимости
            if (LevelScreen == null)
            {
                TryGetLevelScreenText();
            }
        }

        /// <summary>
        /// Получение текстового поля интерфейса, которое отвечает за данный параметр профиля
        /// </summary>
        public virtual void TryGetLevelScreenText()
        {
            LevelScreen = Player.LevelScreen;
        }
    }
}