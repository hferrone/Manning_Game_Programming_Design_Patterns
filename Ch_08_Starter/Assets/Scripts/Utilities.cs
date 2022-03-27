using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Up, Down, Left, Right, Null
}

public static class Utilities
{
    public static Direction ReversedDirection(Direction direction)
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