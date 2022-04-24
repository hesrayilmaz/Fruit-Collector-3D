using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int power = 0;
    private int maxPower = 100;
   
    public void increasePower()
    {
        if ((power+10) > maxPower)
        {
            power = maxPower;
        }
        else
        {
            power += 10;
        }
    }
    public void decreasePower()
    {
        if ((power-10) < 0)
        {
            power = 0;
        }
        else
        {
            power -= 10;
        }
    }
}
