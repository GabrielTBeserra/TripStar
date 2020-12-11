using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points
{
    [SerializeField]
    public int points { get; set; }

    public Points(int points)
    {
        this.points = points;
    }


    public void RemovePoint()
    {
        if (points > 0)
        {
            points--;
        }
    }

    public void AddPoint()
    {
        points++;
    }
}
