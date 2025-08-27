using System;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitCount = 0;
    void OnCollisionEnter(Collision other)
    {
        hitCount++;
        
        Debug.Log("You have hit something this many times: " + hitCount);
    }
}
