using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// ��� ������� ��������� ������� ����� �����������, ������� ����� ����������� �� �������� ������ � �������� �� ���� ����������
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
            // ����� �������� ������ ����� �� ���� ������ �����, � ��������� ����� �������� � ������ �������������
            if (LevelScreen == null)
            {
                TryGetLevelScreenText();
            }
        }

        /// <summary>
        /// ��������� ���������� ���� ����������, ������� �������� �� ������ �������� �������
        /// </summary>
        public virtual void TryGetLevelScreenText()
        {
            LevelScreen = Player.LevelScreen;
        }
    }
}