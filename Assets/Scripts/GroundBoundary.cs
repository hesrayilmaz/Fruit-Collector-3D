using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBoundary : MonoBehaviour
{
    public static float leftSide;
    public static float rightSide;
    public float controlLeftSide;
    public float controlRightSide;
    public float controlDownSide;
    public GameObject player;
   
    // Update is called once per frame
    void Update()
    {
        leftSide = controlLeftSide;
        rightSide = controlRightSide;

        if (player.transform.position.y < controlDownSide)
        {
            Vector3 temp = new Vector3(0, controlDownSide, 0) * Time.deltaTime;
            player.transform.position += temp;
        }

    }
}
