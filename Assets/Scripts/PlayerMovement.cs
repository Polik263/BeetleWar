using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private float speed = 800f;

    [SerializeField] private float horizontal;

    //public Animator animator;

    public GameObject player;

    //public bool gameOver;

    public GameObject gameOverScreen;

    private void Start()
    {
        horizontal= 0;
        player = this.gameObject;
        rb = player.GetComponent<Rigidbody2D>();
        //gameOver = false;
        //animator = player.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
            horizontal = 1;

         if (Input.GetKeyDown(KeyCode.A))
            horizontal = -1;

         if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
             horizontal = 0;

         transform.position += new Vector3(horizontal * speed, 0, 0);
         //rb.velocity = new Vector2(horizontal * speed * Time.deltaTime, 0);

         //rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

         // if(gameOverScreen.activeInHierarchy == true)
         // {
         //     gameOver = true;
         // }
         // else
         // {
         //     gameOver = false;
         // }
    }

    //public void Move(InputAction.CallbackContext context)
    //{
    //    // if (gameOver == false)
    //    // {
    //        horizontal = context.ReadValue<Vector2>().x;
    //    //}
    //}

    //public void Attack(InputAction.CallbackContext context)
    //{
    //    if (context.performed)
    //    {
    //        Debug.Log("Works");
    //        animator.Play("NewAttack");
    //    }
    //}

    //public void Attack2(InputAction.CallbackContext context)
    //{
    //    if (context.performed)
    //    {
    //        Debug.Log("Works");
    //        animator.Play("AttackAnimation2");
    //    }
    //}


    // public void DisableMovement()
    // {
    //     gameOver = true;
    // }
}
