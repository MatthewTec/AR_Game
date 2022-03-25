﻿using UnityEngine;

public class Geometry
{
    static public Vector3 PointFromGrid(Vector2Int gridPoint)
    {
        float x = -3.5f + 1.0f * gridPoint.x;
        float z = -3.5f + 1.0f * gridPoint.y;
        return new Vector3(x * 0.05f, 0, z * 0.05f + 0.88f);
    }

    static public Vector2Int GridPoint(int col, int row)
    {
        return new Vector2Int(col, row);
    }

    static public Vector2Int GridFromPoint(Vector3 point)
    {
        int col = Mathf.FloorToInt((4.0f + point.x) * 0.05f);
        int row = Mathf.FloorToInt((4.0f + point.z) * 0.05f);
        return new Vector2Int(col, row);
    }
}
