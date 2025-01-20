using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public CanvasManager canvasManager;
    public GameObject ball;
    public int deaths = 0;
    public int coins;
    public int checkpointReached = 0;
    bool hasMoved;
    public bool hasJumpPowerUp;
    public bool hasSpeedPowerUp;
    public bool hasJumpBoostPowerUp;

    bool jumpPowerUpTutorial;
    bool speedPowerUpTutorial;

    Vector3 respawnPos;

    void Start()
    {
        respawnPos = new Vector3(0.0f, 1.0f, 0.0f);
        hasMoved = false;
        hasJumpPowerUp = false;
        hasSpeedPowerUp = false;
        hasJumpBoostPowerUp = false;

        jumpPowerUpTutorial = true;
        speedPowerUpTutorial = true;

        RespawnPlayer();
    }

    void Update()
    {
        if (!hasMoved)
        {
            canvasManager.DisplayTutorialText("Press [WASD] to move");

            if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Horizontal") > 0) {
                hasMoved = true;
                canvasManager.DisplayTutorialText("");
            }
        }

        if (hasJumpPowerUp && jumpPowerUpTutorial)
        {
            canvasManager.DisplayTutorialText("Press [SPACE] to jump");

            if (Input.GetAxis("Jump") > 0) {
                canvasManager.DisplayTutorialText("");
                jumpPowerUpTutorial = false;
            }
        }

        if (hasSpeedPowerUp && speedPowerUpTutorial)
        {
            canvasManager.DisplayTutorialText("Press [Left Shift] to move quicker");

            if (Input.GetKeyDown(KeyCode.LeftShift)) {
                canvasManager.DisplayTutorialText("");
                speedPowerUpTutorial = false;
            }
        }
    }

    public void RespawnPlayer() {
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.transform.position = respawnPos;   
    }

    public void UpdateCheckpoint(int checkpointNum, Vector3 checkpointPos) {
        checkpointReached = checkpointNum;
        respawnPos = checkpointPos;
    }
}
