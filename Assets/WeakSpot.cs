using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakSpot : MonoBehaviour
{
    public Rigidbody2D weakSpot;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag("Horn"))
            return;
        float impactStrength = 200f;
        // the collision point:
        Vector2 point = col.contacts[0].point;
        // Option A: Use the direction of the collision surface:
        Vector2 normal = col.contacts[0].normal;
        // Option B: you can also just always apply force upwards:
        normal = Vector2.up;
        col.otherCollider.GetComponent<Rigidbody2D>().AddForceAtPosition(normal * impactStrength, point);

        Debug.Log("ForceIsAdded");
    }
}
