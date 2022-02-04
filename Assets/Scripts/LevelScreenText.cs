using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// ��� ������� ��������� ������� �������� ��������� ����, ����� ������ ���� �������
    /// </summary>
    public abstract class LevelScreenText : MonoBehaviour
    {
        internal Player Player;

        internal TextMeshProUGUI Text;

        /// <summary>
        /// ������� ����� ������, ������� ����� ������������ ������
        /// </summary>
        internal string Message;

        [SerializeField] internal Vector2 AnchoredPosition = new(150f, -75f);
        [SerializeField] internal Vector2 SizeDelta = new(300f, 100f);
        [SerializeField] internal Vector2 AnchorMin = new(0f, 1f);
        [SerializeField] internal Vector2 AnchorMax = new(0f, 1f);

        private void Awake()
        {
            Player = FindObjectOfType<Player>();

            // ������ ������ ��� ������
            GameObject movesTextGameObject = new();
            movesTextGameObject.transform.SetParent(transform, false);

            // ��������� � ������� �����
            Text = movesTextGameObject.AddComponent<TextMeshProUGUI>();
            Text.alignment = TextAlignmentOptions.Center;
            Text.fontSize = 40f;

            // ���������� ������, ����� ������
            RectTransform movesTextRectTransform = movesTextGameObject.GetComponent<RectTransform>();
            movesTextRectTransform.anchoredPosition = AnchoredPosition;
            movesTextRectTransform.sizeDelta = SizeDelta;
            movesTextRectTransform.anchorMin = AnchorMin;
            movesTextRectTransform.anchorMax = AnchorMax;
        }

        public void SetText(int value)
        {
            Text.text = Message + value;
        }
    }
}