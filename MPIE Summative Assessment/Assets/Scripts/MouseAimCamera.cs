using UnityEngine;

public class MouseAimCamera : MonoBehaviour
{
    /**
     * This script is based upon an exaxmple from 'envato tuts+'
     Reference
     * Author: Ian Zamojc
     * Location: https://code.tutsplus.com/unity3d-third-person-cameras--mobile-11230t
     * Accessed: 21/01/2025
    */
    public GameObject target;
    public float rotateSpeed = 5;
    Vector3 offset;
    public GameObject menu;
    public GameObject finishMenu;
    
    void Start() {
        offset = target.transform.position - transform.position;

        //I added the following lines to lock mouse movement
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //Modification ends
    }
    
    void LateUpdate() {
        //I added the following if statement to only update camera location when menus are not active
        if (!menu.activeInHierarchy && !finishMenu.activeInHierarchy) {
            //My modifcation ends

            //Updates camera location based on mouse axis
            float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
            target.transform.Rotate(0, horizontal, 0);
            float desiredAngle = target.transform.eulerAngles.y;
            Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
            transform.position = target.transform.position - (rotation * offset);
            
            transform.LookAt(target.transform);
        }
    }
}
