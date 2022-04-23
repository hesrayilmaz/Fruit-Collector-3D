using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBoundary : MonoBehaviour
{
    public static float leftSide;
    public static float rightSide;
    public float controlLeftSide;
    public float controlRightSide;
   
    // Update is called once per frame
    void Update()
    {
        leftSide = controlLeftSide;
        rightSide = controlRightSide;
    }
}
