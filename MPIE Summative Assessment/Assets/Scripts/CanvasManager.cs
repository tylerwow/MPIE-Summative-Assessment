using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public PlayerManager playerManager;

    public Text deathsText;

    public Text coinsText;

    public Text checkpointText;

    public Text tutorialText;

    public Image jumpPowerUpImage;

    public Image speedPowerUpImage;

    public Image jumpBoostPowerUpImage;

    void Start()
    {
        jumpPowerUpImage.enabled = false;
        speedPowerUpImage.enabled = false;
        jumpBoostPowerUpImage.enabled = false;
    }

    void Update()
    {
        deathsText.text = playerManager.deaths.ToString();
        coinsText.text = playerManager.coins.ToString();

        DisplayJumpPowerUpImage();
        DisplaySpeedPowerUpImage();
        DisplayJumpBoostPowerUpImage();
    }

    public void DisplayCheckpointText(string text)
    {
        checkpointText.text = text;
    }

    public void DisplayTutorialText(string text) {
        tutorialText.text = text;
    }

    void DisplayJumpPowerUpImage()
    {
        if(playerManager.hasJumpPowerUp)
        {
            jumpPowerUpImage.enabled = true;
        }
    }

    void DisplaySpeedPowerUpImage()
    {
        if (playerManager.hasSpeedPowerUp)
        {
            speedPowerUpImage.enabled = true;
        }
    }

    void DisplayJumpBoostPowerUpImage() {
        if(playerManager.hasJumpBoostPowerUp)
        {
            jumpBoostPowerUpImage.enabled = true;
        }
    }
}
