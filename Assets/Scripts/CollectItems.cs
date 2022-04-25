using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public readonly int maxPower = 100;
    public static readonly int powerLimit = 70;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruit"))
        {
            Destroy(other.gameObject);
            increasePower();
        }
        else if (other.CompareTag("Hamburger"))
        {
            Destroy(other.gameObject);
            decreasePower();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.tag=="Obstacle")
        {
            decreasePower();
        }
    }


    public void increasePower()
    {
        if ((ScoreUI.power + 10) > maxPower)
        {
           ScoreUI.power = maxPower;
        }
        else
        {
            ScoreUI.power += 10;
        }
        
    }
    public void decreasePower()
    {
        if ((ScoreUI.power - 10) < 0)
        {
            ScoreUI.power = 0;
        }
        else
        {
            ScoreUI.power -= 10;
        }
      
    }

    public int getPowerLimit()
    {
        return powerLimit;
    }
}
