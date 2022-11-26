using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 8f;

    private float horizontal;

    public Animator animator;

    public GameObject player;

    private void Start()
    {
        animator = player.GetComponent<Animator>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }

    public void Attack(InputAction.CallbackContext context) 
    {
        if (context.performed)
        {
            Debug.Log("Works");
            animator.Play("AttackAnimation");
            animator.Play("AttackAnimation2");
        }
    }

    public void Attack2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Works");
            animator.Play("AttackAnimation2");
        }
    }
}
