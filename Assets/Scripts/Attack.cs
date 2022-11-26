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
            Debug.Log("Works");
            animator.Play("NewAttack");
        }
    }
}
