using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class cube_rotation : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        XRotation();
        YRotation();
    }

    private void XRotation()
    {
        float mouseX = Input.GetAxis("Mouse X");

        Vector3 rotation = transform.localEulerAngles;
        rotation.y += mouseX * Time.deltaTime * rotationSpeed;
        print("Rotation in Y-axis : " + rotation.y +" degrees");
        transform.localEulerAngles = rotation;
    }

    private void YRotation()
    {
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 rotation = transform.localEulerAngles;
        rotation.x += mouseY * Time.deltaTime * rotationSpeed;
        print("Rotation in X-axis : " + rotation.x +" degrees");
        transform.localEulerAngles = rotation;
    }
}