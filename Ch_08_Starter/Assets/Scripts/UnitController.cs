using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    public int distance;
    public GameObject projectile;
    public GameObject shield;
    public float projectileSpeed = 100f;

    private Transform _transform;

    void Start()
    {
        _transform = this.GetComponent<Transform>();
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
        StartCoroutine(Rotate(Vector3.up, 180, 0.5f, 2));
        Debug.Log("Melee attack!");
    }

    public void Block()
    {
        GameObject newShield = Instantiate(shield, _transform.position + Vector3.forward * 1, _transform.rotation);
        Debug.Log("Shield up!");
    }

    public void Move(Vector3 targetPos)
    {
        _transform.position = targetPos;
    }

    private IEnumerator Rotate(Vector3 axis, float angle, float duration, int rotations)
    {
        for(int i = 0; i < rotations; i++)
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
}