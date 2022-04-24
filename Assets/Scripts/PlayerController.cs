using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed;
    public float horizontalSpeed;

    public float jumpForce;
    private Rigidbody rb;
    public bool isPlayerOnGround = true;
  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

         transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed, Space.World);
       
        
        if (Input.GetKey(KeyCode.LeftArrow) && this.gameObject.transform.position.x>GroundBoundary.leftSide)
        {
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
           
           
        }
        else if (Input.GetKey(KeyCode.RightArrow) && this.gameObject.transform.position.x < GroundBoundary.rightSide)
        {
              transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);
           
        }

        if (Input.GetKey(KeyCode.UpArrow) && isPlayerOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //isPlayerOnGround = false;
        }
       
    }

 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isPlayerOnGround = true;
        }
    }
    
}
