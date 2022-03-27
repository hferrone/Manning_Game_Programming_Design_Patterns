using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static Direction Reverse(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up: return Direction.Down;
            case Direction.Down: return Direction.Up;
            case Direction.Left: return Direction.Right;
            case Direction.Right: return Direction.Left;
            default: return Direction.Null;
        }
    }
}