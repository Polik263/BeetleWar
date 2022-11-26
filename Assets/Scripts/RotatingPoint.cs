using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPoint : MonoBehaviour
{
    float RotationSpeed;
    public Rigidbody2D rb;
    public float KnockBackForceUp = 10f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))
        //    GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 45);
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            rb.AddForce(Vector2.up * KnockBackForceUp);
            Debug.Log("Pressed W");
        }
          


        
    }
}
