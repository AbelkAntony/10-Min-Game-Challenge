using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int point;

    public void ResetPoint()
    {
        point = 0;
    }

    public void AddPoint()
    {
        point++;
    }
}
