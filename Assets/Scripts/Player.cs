using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        public LevelMenu LevelMenu;

        /// <summary>
        /// ����� ������� ������ ������
        /// </summary>
        [HideInInspector] public LevelScreen LevelScreen;

        /// <summary>
        ///  ����� ������ �������
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