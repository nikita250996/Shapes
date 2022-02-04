using UnityEngine;

namespace Assets.Scripts
{
    public abstract class Shape : MonoBehaviour
    {
        internal Player Player;

        /// <summary>
        /// ������� ������
        /// </summary>
        [SerializeField] internal int Size = 1;

        private void Awake()
        {
            Player = FindObjectOfType<Player>();

            SetScale();
        }

        internal void SetScale()
        {
            transform.localScale = new Vector3(Size, Size);
        }

        // ����� � ��������� ������� ������� ������� �� ����� ��� ��������� Size ��������������
        private void OnValidate()
        {
            SetScale();
        }
    }
}