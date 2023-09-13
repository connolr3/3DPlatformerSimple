using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;//allows us to access image



public class PlayerMovement : MonoBehaviour
{
 [SerializeField] AudioSource PlayerJump;
 [SerializeField] AudioSource KillEnemy;



    Rigidbody rb;
   [SerializeField] Transform TheGroundCheck;
   [SerializeField] RawImage LogoImage;
   [SerializeField] LayerMask Ground;
   [SerializeField] float MovementSpeed = 6f;//if we said public, we could also edit from unity editor but other scripts could access this variable
    [SerializeField]  float JumpSpeed = 3f;// [SerializeField]  means it can be edited from unity editor

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Starting");
        Invoke("DisableLogo", 5f);
    }
 void DisableLogo()
   { 
       LogoImage.enabled=false;
   }  
    // Update is called once per frame
    void Update()
    {
//local variables
if (Input.anyKey){
    DisableLogo();
}
            float horizontalInput = Input.GetAxis("Horizontal");//gets input for hozizontal axes
           float verticalInput = Input.GetAxis("Vertical");//gets input for hozizontal axes

           //save the position of the rb to new position
           rb.velocity=new Vector3(horizontalInput*MovementSpeed,rb.velocity.y,verticalInput*MovementSpeed);


        //jump... get key down is executed once, and doesn't account for holding. key means get input from keyboard
        //jump... get button down is executed once, and doesn't account for holding. button means get input from unity input manager
        if (Input.GetButtonDown("Jump") && OnGround())//returns true if space is pressed
        {
Debug.Log("jumping");
          jump();
        }
//getkey accounts for holding a button
    }



//jump on top
private  void OnCollisionEnter(Collision collision){
if(collision.gameObject.CompareTag("EnemyHead")){
    KillEnemy.Play();
   Destroy(collision.transform.parent.gameObject);
   jump();
}
 }

void jump(){
  PlayerJump.Play();
     rb.velocity = new Vector3(rb.velocity.x,JumpSpeed,rb.velocity.z);//adding f means compiler knows it is a float
}
    bool OnGround(){
     return  Physics.CheckSphere(TheGroundCheck.position,0.1f,Ground);//unity library/method
       //0.1f refers to radius of sphere it checks for overlap
    }
}
