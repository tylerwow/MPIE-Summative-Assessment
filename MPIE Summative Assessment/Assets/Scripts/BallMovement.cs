using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float initialSpeed = 200.0f;
    float speed;
    float jumpPower;
    float distToGround;
    public PlayerManager playerManager;
    Rigidbody rb;
    Collider c;

    void Start()
    {
        speed = initialSpeed;
        jumpPower = 75.0f;

        rb = GetComponent<Rigidbody>();
        c = GetComponent<Collider>();
        distToGround = c.bounds.extents.y;
    }

    void FixedUpdate()
    {
        //Ball movement
        float zMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float xMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        rb.AddForce(Camera.main.transform.TransformDirection(new Vector3(xMovement, 0.0f, zMovement)));

        //Increases jump power
        if (playerManager.hasJumpBoostPowerUp) {
            jumpPower = 200.0f;
            rb.drag = 0;
        }

        //Jump
        if (Input.GetAxis("Jump") > 0 && isGrounded() && playerManager.hasJumpPowerUp == true) {
            rb.AddForce(new Vector3(0.0f, jumpPower, 0.0f));
        }

        //Speed Boost
        if (Input.GetKey(KeyCode.LeftShift) && playerManager.hasSpeedPowerUp == true) {
            speed = initialSpeed * 2;
            Camera.main.fieldOfView = 95;
        }
        else {
            speed = initialSpeed;
            Camera.main.fieldOfView = 80;
        }
    }

    /**
     * This function is based upon an example from the Unity forum
     Reference
     * Author: aldonaletto
     * Location: https://discussions.unity.com/t/how-do-i-check-if-my-rigidbody-player-is-grounded/33250
     * Accessed 21/01/2025
    */
    bool isGrounded() {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }
}   
