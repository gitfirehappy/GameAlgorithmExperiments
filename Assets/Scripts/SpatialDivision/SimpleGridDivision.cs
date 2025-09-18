using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleGrid
{
    public static class GridSystem
    {
        public static int mapWidth, mapHeight;
        public static float cellSize;
        public static bool[,] walkableMap;
        
        public static void InitializeGrid(int width, int height, float size)
        {
            mapWidth = width;
            mapHeight = height;
            cellSize = size;
            walkableMap = new bool[width, height];
            for (int x = 0; x < width; x++)
            for (int y = 0; y < height; y++)
                walkableMap[x, y] = true;
        }
    
        public static bool IsInBounds(float x, float y)
        {
            return x >= 0 && x < mapWidth && y >= 0 && y < mapHeight;
        }
    
        public static bool IsWalkable(int x, int y) {
            return IsInBounds(x, y) && walkableMap[x, y];
        }
        
        public static Vector2Int WorldToGrid(Vector3 pos)
        {
            int x = Mathf.FloorToInt(pos.x / cellSize);
            int y = Mathf.FloorToInt(pos.z / cellSize);
            return new Vector2Int(x, y);
        }
        
        public static Vector3 GridToWorld(Vector2Int gridPos)
        {
            float x = gridPos.x * cellSize / 2f;
            float y = gridPos.y * cellSize / 2f;
            return new Vector3(x, y, 0);
        }
    
        // TODO: 参数需要替换成节点
        public static List<Vector2Int> GetNeighbours(int x, int y)
        {
            List<Vector2Int> result = new List<Vector2Int>();
            int[] move = { -1, 0, 1, 0, -1 };
            for (int i = 0; i < 4; i++) {
                int nx = x + move[i], ny = y + move[i + 1];
            }
            return result;
        }
    }

    public static class GridNode
    {
        
    }
}


