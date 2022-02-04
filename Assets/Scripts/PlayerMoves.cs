namespace Assets.Scripts
{
    /// <summary>
    /// ќбработка успешных перемещений квадратов
    /// </summary>
    public class PlayerMoves : PlayerParameter
    {
        public override void SuccessfulAction()
        {
            base.SuccessfulAction();

            if (LevelScreen != null)
            {
                LevelScreenText.SetText(++Value);
            }

            Player.SelectedShape = null;
        }

        public override void TryGetLevelScreenText()
        {
            base.TryGetLevelScreenText();

            LevelScreenText = LevelScreen != null ? LevelScreen.GetComponent<LevelScreenMoves>() : null;
        }
    }
}