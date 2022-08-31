using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 10.0f;

    public float groundDrag;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection; 

    private Rigidbody myRigidbody;
    public Animator anim;


    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        myRigidbody.freezeRotation = true;
    }

    private void Update()
    {
        //ground check
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.65f + 0.2f, whatIsGround);

        Inputs();
        SpeedControl();

        if (grounded)
            myRigidbody.drag = groundDrag;
        else
            myRigidbody.drag = 0;
    }

    private void FixedUpdate()
    {
        MovePlayer();
       // Movement();
    }

    private void Inputs()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        //calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        //on ground
        if (grounded)
        { 
            myRigidbody.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force); 
        }



        if (myRigidbody.velocity == Vector3.zero)
        {
            anim.SetBool("Correr", false);
        }
        else
        {
            anim.SetBool("Correr", true);
        }
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(myRigidbody.velocity.x, 0f, myRigidbody.velocity.z);

        //limit velocity if needed
        if(flatVel. magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            myRigidbody.velocity = new Vector3(limitedVel.x, myRigidbody.velocity.y, limitedVel.z);
        }
    }
    public static float playerHP = 100f;
}
