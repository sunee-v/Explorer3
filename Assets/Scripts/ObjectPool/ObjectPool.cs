using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
  
    private IObjectPool<GameObject> pool;

    void Awake()
    {
        pool = new ObjectPool<GameObject>(() => Instantiate(prefab));
    }

    public GameObject GetObject()
    {
        return pool.Get();
    }

    public void ReturnObject(GameObject obj)
    {
        pool.Release(obj);
    }

}
