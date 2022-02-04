using Assets.Scripts;
using UnityEngine;

namespace Assets.Expansion.Scripts
{
    /// <summary>
    /// ����������� ���������� �� ������� � ��������� ���������� �������������
    /// </summary>
    public class LevelScreenEnergyTriangle : LevelScreenText
    {
        [SerializeField] private int _energy = 3;

        private void Start()
        {
            Message = "Energy: ";

            // ��� ��������� ������ ���������� ����� �������� ������� ����������� ������ � ��������
            PlayerEnergyTriangle playerEnergyTriangle = Player.gameObject.GetComponent<PlayerEnergyTriangle>();
            if (playerEnergyTriangle == null)
            {
                playerEnergyTriangle = Player.gameObject.AddComponent<PlayerEnergyTriangle>();
                playerEnergyTriangle.Value = _energy;
            }

            SetText(playerEnergyTriangle.Value);

            // ��������� ������������� ������������ �� �������
            Cube[] cubes = FindObjectsOfType<Cube>();
            foreach (Cube cube in cubes)
            {
                CubeTriangle cubeTriangle = cube.gameObject.AddComponent<CubeTriangle>();
                int size = cube.Size;
                Destroy(cube);
                Cube newCube = cubeTriangle.gameObject.AddComponent<Cube>();
                newCube.Size = size;
                newCube.SetScale();
            }

            // ��������� ������������� ������������ �� ����
            Circle[] circles = FindObjectsOfType<Circle>();
            foreach (Circle circle in circles)
            {
                CircleTriangle circleTriangle = circle.gameObject.AddComponent<CircleTriangle>();
                int size = circle.Size;
                Destroy(circle);
                Circle newCircle = circleTriangle.gameObject.AddComponent<Circle>();
                newCircle.Size = size;
                newCircle.SetScale();
            }
        }
    }
}