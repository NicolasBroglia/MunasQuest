using UnityEngine;
/*public class PlayerInputs : MonoBehaviour
{
    //public float speed = 20f;

    public Rigidbody rb; //el jugador debe tener rigid body con freze rotation en x,y,z 

    public Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
*/
/*
    void FixedUpdate()
    {
        // MOVIMIENTO CON FISICAS Move();

    
    if (Input.GetKeyDown(KeyCode.P))
    {
        ToggleCamera();
    }
    */

    // MOVIMIENTO CON FISICAS
  /*
    void Move()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 inputJugador = new Vector3(hor, 0, ver);
        rb.AddForce(inputJugador * speed);
        if (inputJugador == Vector3.zero)
        {
            anim.SetBool("Correr", false);
        }
        else
        {
            anim.SetBool("Correr", true);
        }

    }
   
    /*
     //sist de camaras:

     public GameObject camUno;
     public GameObject camDos;

     //switch camera vision

     void ToggleCamera()
     {
         if (camUno.activeInHierarchy)
         {
             camUno.SetActive(false);
             camDos.SetActive(true);
         }
         else
         {
             camUno.SetActive(true);
             camDos.SetActive(false);
         }
     }
    */
    

