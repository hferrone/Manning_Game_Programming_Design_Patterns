using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Shared;

    public GameObject pooledObject;
    public int poolSize;

    private List<GameObject> _available = new List<GameObject>();
    private List<GameObject> _inUse = new List<GameObject>();

    void Awake()
    {
        Shared = this;
        FillPool();
    }

    public GameObject GetProjectile()
    {
        if(_available.Count != 0)
        {
            GameObject projectile = _available[0];
            _inUse.Add(projectile);
            _available.Remove(projectile);
            projectile.SetActive(true);

            return projectile;
        }

        return null;
    }

    public void ReturnProjectile(GameObject go)
    {
        _available.Add(go);
        _inUse.Remove(go);
        go.SetActive(false);
    }

    void CreateProjectile()
    {
        GameObject projectile = Instantiate(pooledObject);
        _available.Add(projectile);
        projectile.transform.SetParent(this.transform);
        projectile.SetActive(false);
    }

    void FillPool()
    {
        for(int i = 0; i < poolSize; i++)
        {
            CreateProjectile();
        }
    }
}