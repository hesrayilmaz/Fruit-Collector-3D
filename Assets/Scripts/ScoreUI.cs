using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour
{
    public Text powerText;
    public static int power = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        powerText.text = "" + power;
    }

    
}