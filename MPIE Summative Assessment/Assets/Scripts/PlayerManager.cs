using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject ball;
    public int lives = 3;
    public int coins;
    public int checkpointReached = 0;
    public bool hasJumpPowerUp;
    public bool hasSpeedPowerUp;
    Vector3 respawnPos;

    void Start()
    {
        respawnPos = new Vector3(0.0f, 1.0f, 0.0f);
        hasJumpPowerUp = false;
        hasSpeedPowerUp = false;

        RespawnPlayer();
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
