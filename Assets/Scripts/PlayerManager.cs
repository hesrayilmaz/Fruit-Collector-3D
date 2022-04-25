using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameStarted;
    public GameObject startingText;

    // Start is called before the first frame update
    void Start()
    {
        isGameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnEnable()
    {
        Lean.Touch.LeanTouch.OnFingerTap += HandleFingerTap;
    }
    void HandleFingerTap(Lean.Touch.LeanFinger finger)
    {
        isGameStarted = true;
        Destroy(startingText);
    }
}
