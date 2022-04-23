using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed;
    public float horizontalSpeed;

    // Update is called once per frame
    void Update()
    {
        // direction.z = forwardSpeed;
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed, Space.World);

        if (Input.GetKey(KeyCode.LeftArrow) && this.gameObject.transform.position.x>GroundBoundary.leftSide)
        {
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && this.gameObject.transform.position.x < GroundBoundary.rightSide)
        {
            transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);
        }
    }

}
