using Assets.Scripts;
using UnityEngine.EventSystems;

namespace Assets.Expansion.Scripts
{
    public class Triangle : Shape, IPointerClickHandler
    {
        // Треугольники можно добавлять только на уровни со включённым расширением
        private void Start()
        {
            if (transform.parent.gameObject.GetComponent<LevelScreenEnergyTriangle>() == null)
            {
                Destroy(gameObject);
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (this == Player.SelectedShape)
            {
                return;
            }

            Player.SelectedShape = this;
        }
    }
}