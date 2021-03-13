using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMan : MonoBehaviour
{
    [SerializeField] private float _speedRotate;
    private float _mouseX;
    private float _mouseY;
    private void FixedUpdate()
    {
        _mouseX += Input.GetAxis("Mouse X") * _speedRotate;
        _mouseY += Input.GetAxis("Mouse Y") * _speedRotate;

        _mouseX = Mathf.Clamp(_mouseX, -80, 80);
        _mouseY = Mathf.Clamp(_mouseY, 0, 50);

        Quaternion rotateX = Quaternion.AngleAxis(_mouseX, Vector3.up);
        Quaternion rotateY = Quaternion.AngleAxis(-_mouseY, Vector3.right);

        transform.rotation = rotateX * rotateY;
    }
}
