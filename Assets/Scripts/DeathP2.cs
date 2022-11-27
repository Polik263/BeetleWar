using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DeathP2 : MonoBehaviour
{
    private GameObject player;
    public int scene;
    public Animator animator;
    private PlayerMovement _playerMovement;
    public GameObject weakSpot;
    public GameObject UIDeathPrompt;


    private void Start()
    {
        player = this.gameObject;
        animator = player.GetComponent<Animator>();
        _playerMovement = player.GetComponent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        _playerMovement.enabled = false;
        if (other.CompareTag("HornP1"))
        {
            Debug.Log("Death");
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
