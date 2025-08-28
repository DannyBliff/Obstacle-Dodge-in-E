using System;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitCount = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hitCount++;
            Debug.Log("You have hit something this many times: " + hitCount);
        }
            
        
    }
}
