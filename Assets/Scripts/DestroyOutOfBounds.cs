using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    [SerializeField] float topBounds = 30;
    [SerializeField] float bottomBounds = -30;

    // Start is called before the first frame update
    void Start()
    {
        //not needed
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <= bottomBounds)
        {
            CheckEndGame();
            Destroy(gameObject); 
        }
        
    }

    void CheckEndGame()
    {
        if (transform.position.z < bottomBounds)
        {
            print("Game Over");
            //Destroy(gameObject);
        }
    }
}
