using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Knockback : MonoBehaviour
{
    public Rigidbody2D rb;
    public float KnockBackForce = 2;
    public float KnockBackForceUp = 10;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.up * 200f);
        }
    }


}
