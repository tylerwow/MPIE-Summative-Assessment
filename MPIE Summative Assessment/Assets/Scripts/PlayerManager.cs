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
    }

    void Update()
    {
        //Shows movement tutorial text
        if (!hasMoved)
        {
            canvasManager.DisplayTutorialText("Press [WASD] to move");

            if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Horizontal") > 0) {
                hasMoved = true;
                canvasManager.DisplayTutorialText("");
            }
        }

        //Shows jump tutorial text
        if (hasJumpPowerUp && jumpPowerUpTutorial)
        {
            canvasManager.DisplayTutorialText("Press [SPACE] to jump");

            if (Input.GetAxis("Jump") > 0) {
                canvasManager.DisplayTutorialText("");
                jumpPowerUpTutorial = false;
            }
        }

        //Shows speed power up text
        if (hasSpeedPowerUp && speedPowerUpTutorial)
        {
            canvasManager.DisplayTutorialText("Press [Left Shift] to move quicker");

            if (Input.GetKeyDown(KeyCode.LeftShift)) {
                canvasManager.DisplayTutorialText("");
                speedPowerUpTutorial = false;
            }
        }
    }

    //Respawns player and cancels ball's velocity
    public void RespawnPlayer() {
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.transform.position = respawnPos;  
        deaths++;
    }

    //Updates respawn position
    public void UpdateCheckpoint(int checkpointNum, Vector3 checkpointPos) {
        checkpointReached = checkpointNum;
        respawnPos = checkpointPos;
    }
}
