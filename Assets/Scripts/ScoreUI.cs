using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour
{
    public Text powerText;
    public static int power = 0;
   
    private void Update()
    {
        powerText.text = "" + power;
    }

    
}