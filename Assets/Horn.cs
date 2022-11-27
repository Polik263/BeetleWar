using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horn : MonoBehaviour
{
    public float rotationSpeed = 40f;
    public float bottomRotationClamp = 20;
    public float topRotationClamp = -20f;

    void Update()
    {
        Vector3 rotation = transform.localRotation.eulerAngles;
        Vector3 delta = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            delta -= Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            delta += Vector3.forward;
        }

        delta *= Time.deltaTime * rotationSpeed;
        rotation += delta;
        rotation.z = Mathf.Clamp(rotation.z, topRotationClamp, bottomRotationClamp);
        transform.localRotation = Quaternion.Euler(rotation);
    }
}
