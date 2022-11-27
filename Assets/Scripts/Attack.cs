using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Attack : MonoBehaviour
{
    public Animator animator;
    public Animator enemyAnimator;
    public GameObject horn;
    public GameObject enemy;

    private void Start()
    {
        animator = horn.GetComponent<Animator>();
        enemyAnimator = enemy.GetComponent<Animator>();
    }

    public void Attack1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            animator.Play("NewAttack");
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.collider.CompareTag("WeakSpot"))
        {
            enemyAnimator.Play("Death");

            Debug.Log("Dead");
        }
        //    return;
        //float impactStrength = 150f;
       
        //Vector2 point = col.contacts[0].point;
       
        //Vector2 normal = col.contacts[0].normal;
       
        //normal = Vector2.up;
        //col.collider.GetComponentInParent<Rigidbody2D>().AddForceAtPosition(normal * impactStrength, point);


        
    }

}
