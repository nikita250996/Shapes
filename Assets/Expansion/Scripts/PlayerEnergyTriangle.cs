using Assets.Scripts;

namespace Assets.Expansion.Scripts
{
    /// <summary>
    /// Обработка энергии
    /// </summary>
    public class PlayerEnergyTriangle : PlayerParameter
    {
        public override void SuccessfulAction()
        {
            base.SuccessfulAction();

            if (LevelScreen != null)
            {
                LevelScreenText.SetText(--Value);
            }
        }

        public override void TryGetLevelScreenText()
        {
            base.TryGetLevelScreenText();

            LevelScreenText = LevelScreen != null ? LevelScreen.GetComponent<LevelScreenEnergyTriangle>() : null;
        }
    }
}