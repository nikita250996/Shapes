using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// ����������� ���������� �� �������� ������������ ���������
    /// </summary>
    public class LevelScreenMoves : LevelScreenText
    {
        private void Start()
        {
            Message = "Moves: ";

            SetText(Player.gameObject.GetComponent<PlayerMoves>().Value);
        }
    }
}