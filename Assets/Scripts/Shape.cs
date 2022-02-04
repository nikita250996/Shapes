using UnityEngine;

namespace Assets.Scripts
{
    public abstract class Shape : MonoBehaviour
    {
        internal Player Player;

        /// <summary>
        /// Масштаб фигуры
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

        // Чтобы в редакторе менялся масштаб объекта на сцене при изменении Size геймдизайнером
        private void OnValidate()
        {
            SetScale();
        }
    }
}