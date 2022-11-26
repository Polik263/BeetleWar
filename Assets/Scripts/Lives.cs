using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int maxLives = 3;
    private int currentLives;
    void Start()
    {
        currentLives = maxLives;
    }

    // Update is called once per frame
    void TakeHit(int hit)
    {
        currentLives -= hit; 
        
        
    }
}
