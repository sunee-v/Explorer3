using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    //public GameObject[] target = new GameObject[3];

    Vector3 offset = new Vector3(0,15,0);

    // Start is called before the first frame update
    void Start()
    {
        //not needed
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //between the player and target with offset.
        //transform.position = (player.transform.position + target.transform.position)/2 + offset;

        transform.position = player.transform.position + offset;
    }
}
