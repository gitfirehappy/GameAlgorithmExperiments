using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EstimationFunc
{
    public static int Manhattan(int x1, int y1, int x2, int y2) 
    {
        return Mathf.Abs(x1 - x2) + Mathf.Abs(y1 - y2);
    }
    
    public static float Euclidean(int x1, int y1, int x2, int y2) 
    {
        return Mathf.Sqrt(Mathf.Pow(x1 - x2, 2) + Mathf.Pow(y1 - y2, 2));
    }
    
    public static float Diagonal(int x1, int y1, int x2, int y2) 
    {
        int dx = Mathf.Abs(x1 - x2);
        int dy = Mathf.Abs(y1 - y2);
        return dx + dy - Mathf.Min(dx, dy);
    }
}
