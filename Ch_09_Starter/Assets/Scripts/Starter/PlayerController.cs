using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public GameObject bulletPrefab;
    public float bulletSpeed = 100f;

    private float _horizontalInput;
    private float _verticalInput;
    private bool _isShooting;

    void Update()
    {
        _isShooting |= Input.GetKey(KeyCode.Space);

        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(_horizontalInput, 0f, _verticalInput);
        this.transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        if (_isShooting)
        {
            CreateBullet();
        }

        _isShooting = false;
    }

    void CreateBullet()
    {
        GameObject newBullet = Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);
        Rigidbody bulletRB = newBullet.GetComponent<Rigidbody>();
        bulletRB.velocity = this.transform.forward * bulletSpeed;
    }
}