using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DeathP2 : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public int scene;
    //public Animator animator;
    private PlayerMovement _playerMovement;
    //private Horn2 _horn;
    public GameObject weakSpot;
    public GameObject UIDeathPrompt;


    private void Start()
    {
        //player = this.gameObject;
        //animator = player.GetComponent<Animator>();
        _playerMovement = player.GetComponent<PlayerMovement>();
        //_horn = player.GetComponent<Horn2>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        _playerMovement.enabled = false;
        //_horn.enabled = false;
        if (other.CompareTag("HornP1"))
        {
            Debug.Log("Death");
            Destroy(player.gameObject);
            ActivateUI();
            //animator.Play("DeathAnimation");
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
