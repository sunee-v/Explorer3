using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Serialized fields on inspector
    [SerializeField] private float jumpForce = 0.5f;
    private float walkSpeed = 5;
    private float runSpeed = 7f;

    //bools
    private bool isGround = true;
    private bool jumped = false;
    private bool isRunning = false;

    //rigidbody of player
    private Rigidbody rb;

    // 
    private Vector3 inputAxis;


    //[SerializeField] private float 

    //get the rigidbody when the thing runs
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        move();
    }

    private void move()
    {
        inputAxis.x = Input.GetAxisRaw("Horizontal");
        inputAxis.y = Input.GetAxisRaw("Vertical");
    }
    /*private void run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {

        }
    }
    */
}
