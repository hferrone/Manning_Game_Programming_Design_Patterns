using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Up, Down, Left, Right
}

public class UnitController : MonoBehaviour
{
    public int distance;
    public GameObject projectile;

    public void Move(Direction direction)
    {
        switch(direction)
        {
            case Direction.Up:
                ZAxisMovement(true);
                break;
            case Direction.Down:
                ZAxisMovement(false);
                break;
            case Direction.Left:
                XAxisMovement(true);
                break;
            case Direction.Right:
                XAxisMovement(false);
                break;
        }
    }

    public void Shoot()
    {

    }

    private void ZAxisMovement(bool positiveDelta)
    {
        Vector3 pos = this.gameObject.transform.position;
        var direction = positiveDelta ? pos.z += distance : pos.z -= distance;
        this.gameObject.transform.position = pos;
    }

    private void XAxisMovement(bool positiveDelta)
    {
        Vector3 pos = this.gameObject.transform.position;
        var direction = positiveDelta ? pos.x += distance : pos.x -= distance;
        this.gameObject.transform.position = pos;
    }
}