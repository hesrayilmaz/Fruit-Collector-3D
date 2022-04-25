using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public static bool isGameStarted;
    public GameObject startingText;
    public static bool isGameOver;
    public GameObject gameOverPanel;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        isGameStarted = false;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverPanel.SetActive(true);
        }
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
