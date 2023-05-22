using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int point;

    public HexagonMovement hexagon;

    public void AddPoint()
    {
        point++;
    }
}
