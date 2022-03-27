using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour, Receiver
{
    public int distance;
    public GameObject projectile;
    public GameObject shield;
    public float projectileSpeed = 100f;
    public float jumpImpulse = 5f;

    private Rigidbody _rb;
    private Transform _transform;

    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
        _transform = this.GetComponent<Transform>();
    }

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
                XAxisMovement(false);
                break;
            case Direction.Right:
                XAxisMovement(true);
                break;
        }

        Debug.Log($"Unit moved {direction.ToString()}!");
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(projectile, _transform.position + Vector3.zero, _transform.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
        bulletRB.velocity = _transform.forward * projectileSpeed;
        Debug.Log("Projectile shot!");
    }

    public void Melee()
    {
        StartCoroutine(Rotate(Vector3.up, 180, 0.75f));
        Debug.Log("Perfomed melee attack!");
    }

    public void Block()
    {
        GameObject newShield = Instantiate(shield, _transform.position + Vector3.forward * 1, _transform.rotation);
        Debug.Log("Shield up!");
    }

    private void ZAxisMovement(bool positiveDelta)
    {
        Vector3 pos = _transform.position;
        var direction = positiveDelta ? pos.z += distance : pos.z -= distance;
        _transform.position = pos;
    }

    private void XAxisMovement(bool positiveDelta)
    {
        Vector3 pos = _transform.position;
        var direction = positiveDelta ? pos.x += distance : pos.x -= distance;
        _transform.position = pos;
    }

    private IEnumerator Rotate(Vector3 axis, float angle, float duration = 1.0f)
    {
        Quaternion from = _transform.rotation;
        Quaternion to = _transform.rotation;
        to *= Quaternion.Euler(axis * angle);

        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            _transform.rotation = Quaternion.Slerp(from, to, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        _transform.rotation = to;
    }
}