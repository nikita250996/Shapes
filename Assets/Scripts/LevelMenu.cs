using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class LevelMenu : MonoBehaviour
    {
        /// <summary>
        /// ������, ������� ������������ ����� � ���������
        /// </summary>
        [SerializeField] private LevelScreen[] _levels;

        [SerializeField] private Canvas _canvas;

        /// <summary>
        /// ������, �� ������ �������� � ���� ��������� ������ �������� �� �������
        /// </summary>
        [SerializeField] private GameObject _button;

        private void Awake()
        {
            for (int i = 0; i < _levels.Length;)
            {
                // ������ �� ������ ��� �������� �� ������ �������
                GameObject button = Instantiate(_button);
                button.transform.SetParent(_canvas.transform);

                // ���������� ������, ����� ������
                RectTransform movesTextRectTransform = button.GetComponent<RectTransform>();
                movesTextRectTransform.anchoredPosition = new Vector2(200f * (i + 1), 0);
                movesTextRectTransform.anchorMin = new Vector2(0f, 0.5f);
                movesTextRectTransform.anchorMax = new Vector2(0f, 0.5f);

                // ������� �������, ��� ��� ������ ��������� ��������������� �� �������
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