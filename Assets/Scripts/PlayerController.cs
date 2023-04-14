using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float turnSpeed;

    float xRange = 10;

    float horizontalInput;
    float verticalInput;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        //not needed
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerLocation();
        MovePlayer();
        Throw();

    }

    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        //transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * verticalInput);
    }

    // check the location and coordinates of the player to keep them in bounds
    // make use of if statements.
    void CheckPlayerLocation()
    {
        // keep player in bounds using xRange values instead of hard coded values
        // negative Range values to restrict on the left side of the axis.
        if (transform.position.x < -xRange) 
        {   
            transform.position = new Vector3 (-xRange, transform.position.y, transform.position.z);
        }

        //right side of the axis (consists of positive values)
        else if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
    void Throw()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            //Instantiate spawns a projectilePrefab (in this case the projectile prefab is a food)
            //Instantiate( object that gets spawned, position of where object gets spawned, the rotation of the object spawned);
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
