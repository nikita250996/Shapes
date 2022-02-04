using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Отображение информации об успешных перемещениях квадратов
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