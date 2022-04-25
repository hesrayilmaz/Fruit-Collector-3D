using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed;
    public float horizontalSpeed;
    public float jumpForce;

    public Animator animator;
    private Rigidbody rb;

    //public bool isJumped = false;
    public bool isPlayerOnGround = true;
    private bool isMoving = true;
  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!MenuController.isGameStarted) return;

        if (isMoving)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed, Space.World);

            if (Input.GetKey(KeyCode.LeftArrow) && this.gameObject.transform.position.x > GroundBoundary.leftSide)
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);

            else if (Input.GetKey(KeyCode.RightArrow) && this.gameObject.transform.position.x < GroundBoundary.rightSide)
                transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);

            else if (Input.GetKey(KeyCode.UpArrow))
            {
                //isJumped = true;
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                animator.SetBool("isJumped", true);
                isPlayerOnGround = false;
            }

        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isPlayerOnGround = true;
            //isJumped = false;
            animator.SetBool("isJumped", false);
        }

        if (collision.gameObject.name == "GameOverGround")
        {
            isMoving = false;
            transform.Translate(new Vector3(0, 0, 0));
            MenuController.isGameOver = true;
            
            if (ScoreUI.power < CollectItems.powerLimit)
                animator.SetBool("isUnderLimit", true);

            else
                animator.SetBool("isAboveLimit", true);
        }
    }

}
