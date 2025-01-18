using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAimCamera : MonoBehaviour
{
    //https://code.tutsplus.com/unity3d-third-person-cameras--mobile-11230t
    public GameObject target;
    public float rotateSpeed = 5;
    Vector3 offset;
    
    void Start() {
        offset = target.transform.position - transform.position;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    void LateUpdate() {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.transform.Rotate(0, horizontal, 0);
        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position - (rotation * offset);
        
        transform.LookAt(target.transform);
    }
}
