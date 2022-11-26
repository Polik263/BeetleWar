using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Death : MonoBehaviour
{

    public int scene;
    
    public GameObject UIDeathPrompt;

    
     void OnTriggerEnter2D(Collider2D other)
    {
        
        Debug.Log("Collision!");
        if (other.CompareTag("Ground"))
        {
            Debug.Log("Ground Touched");
            UIDeathPrompt.SetActive(true);
        }
    }

     public void NewGameButton()
     {
         SceneManager.LoadScene(scene);
     }

    
}
