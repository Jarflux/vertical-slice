using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float _turnSpeed = 3f;

    // Update is called once per frame
    void FixedUpdate() {
        if (Input.GetMouseButton(1)) {
            float horizontal = Input.GetAxis("Mouse X");
            transform.Rotate(horizontal * Time.deltaTime * _turnSpeed * Vector3.up, Space.World);
        }
    }
}
