using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Attack : MonoBehaviour
{
    public Animator animator;
    public GameObject horn;

    private void Start()
    {
        animator = horn.GetComponent<Animator>();
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
            return;
        float impactStrength = 150f;
        // the collision point:
        Vector2 point = col.contacts[0].point;
        // Option A: Use the direction of the collision surface:
        Vector2 normal = col.contacts[0].normal;
        // Option B: you can also just always apply force upwards:
        normal = Vector2.up;
        col.collider.GetComponentInParent<Rigidbody2D>().AddForceAtPosition(normal * impactStrength, point);

        Debug.Log("ForceIsAdded");
    }

}
