using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horn2 : MonoBehaviour
{
    public float rotationSpeed = 40f;
    public float bottomRotationClamp = 20;
    public float topRotationClamp = -20f;

    void Update()
    {
        Vector3 rotation = transform.localRotation.eulerAngles;
        rotation.z = (rotation.z + 360 + 180) % 360 - 180;
        Vector3 delta = Vector3.zero;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            delta -= Vector3.forward;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            delta += Vector3.forward;
        }

        delta *= Time.deltaTime * rotationSpeed;
        rotation += delta;
        rotation.z = Mathf.Clamp(rotation.z, topRotationClamp, bottomRotationClamp);
        transform.localRotation = Quaternion.Euler(rotation);
    }
}
