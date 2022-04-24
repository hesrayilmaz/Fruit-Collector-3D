using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    private GameObject fruit;
    private GameObject hamburger;
    ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {
        fruit = GameObject.FindGameObjectWithTag("Fruit");
        hamburger = GameObject.FindGameObjectWithTag("Hamburger");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruit"))
        {
            Destroy(other.gameObject);
            score.increasePower();
        }
        if (other.CompareTag("Hamburger"))
        {
            Destroy(other.gameObject);
            score.decreasePower();
        }
    }
}
