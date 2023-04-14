using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolDestroy : MonoBehaviour
{
    private ObjectPool[] pools = new ObjectPool[0];

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bounds"))
        {
            Destroy(pools[0]);
        }
    }
}
