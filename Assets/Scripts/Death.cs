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
    public Animator animator;
    public GameObject weakSpot;
    public GameObject UIDeathPrompt;


    private void Start()
    {
        animator = weakSpot.GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Horn"))
        {
            Debug.Log("Death");
            UIDeathPrompt.SetActive(true);

            animator.Play("DeathAnimation");
        }
    }

    public void ActivateUI()
    {
        UIDeathPrompt.SetActive(true);
    }

     public void NewGameButton()
     {
         SceneManager.LoadScene(scene);
     }

    
}
