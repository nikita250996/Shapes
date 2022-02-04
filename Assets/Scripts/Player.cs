using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        public LevelMenu LevelMenu;

        /// <summary>
        /// Какой уровень сейчас открыт
        /// </summary>
        [HideInInspector] public LevelScreen LevelScreen;

        /// <summary>
        ///  Какая фигура выбрана
        /// </summary>
        [HideInInspector] public Shape SelectedShape;

#if UNITY_STANDALONE_WIN
        private void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
#endif
    }
}