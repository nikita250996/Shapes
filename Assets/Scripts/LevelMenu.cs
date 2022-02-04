using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class LevelMenu : MonoBehaviour
    {
        /// <summary>
        /// Уровни, которые геймдизайнер задал в редакторе
        /// </summary>
        [SerializeField] private LevelScreen[] _levels;

        [SerializeField] private Canvas _canvas;

        /// <summary>
        /// Префаб, на основе которого в меню создаются кнопки перехода на уровень
        /// </summary>
        [SerializeField] private GameObject _button;

        private void Awake()
        {
            for (int i = 0; i < _levels.Length;)
            {
                // Создаём по кнопке для перехода на каждый уровень
                GameObject button = Instantiate(_button);
                button.transform.SetParent(_canvas.transform);

                // Перемещаем кнопки, задаём размер
                RectTransform movesTextRectTransform = button.GetComponent<RectTransform>();
                movesTextRectTransform.anchoredPosition = new Vector2(200f * (i + 1), 0);
                movesTextRectTransform.anchorMin = new Vector2(0f, 0.5f);
                movesTextRectTransform.anchorMax = new Vector2(0f, 0.5f);

                // Говорим кнопкам, что они должны запускать соответствующий им уровень
                int level = i;
                button.GetComponent<Button>().onClick.AddListener(delegate { RunLevel(level); });
                button.transform.GetChild(0).GetComponent<Text>().text = "Level " + ++i;
            }
        }

        private void RunLevel(int level)
        {
            Instantiate(_levels[level]);
            gameObject.SetActive(false);
        }
    }
}