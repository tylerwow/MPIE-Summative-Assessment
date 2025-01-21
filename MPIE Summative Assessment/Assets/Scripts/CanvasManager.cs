using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public PlayerManager playerManager;

    //Canvas objects
    public Text deathsText;
    public Text coinsText;
    public Text checkpointText;
    public Text tutorialText;
    public Image jumpPowerUpImage;
    public Image speedPowerUpImage;
    public Image jumpBoostPowerUpImage;
    public GameObject menu;
    public GameObject finishMenu;
    public Text finishDeathText;
    public Text finishCoinText;

    void Start()
    {
        jumpPowerUpImage.enabled = false;
        speedPowerUpImage.enabled = false;
        jumpBoostPowerUpImage.enabled = false;

        finishMenu.SetActive(false);
        HideMenu();
    }

    void Update()
    {
        //Updates death and coin count in canvas
        deathsText.text = playerManager.deaths.ToString();
        coinsText.text = playerManager.coins.ToString();

        DisplayJumpPowerUpImage();
        DisplaySpeedPowerUpImage();
        DisplayJumpBoostPowerUpImage();

        //Activates and deactivates menu
        if (Input.GetKeyDown(KeyCode.Escape) && !menu.activeInHierarchy) {
            DisplayMenu();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && menu.activeInHierarchy) {
            HideMenu();
        }
    }

    //Displays "Set Checkpoint"
    public void DisplayCheckpointText(string text)
    {
        checkpointText.text = text;
    }

    //Displays Tutorial text for movement and power ups
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

    //Displays pause menu
    void DisplayMenu()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        Time.timeScale = 0;
        menu.SetActive(true);    
    }

    //Hides pause menu
    public void HideMenu()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        Time.timeScale = 1;
        menu.SetActive(false);
    }

    //Displays finish menu
    public void DisplayFinishMenu()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        finishDeathText.text = playerManager.deaths + " Deaths";
        finishCoinText.text = playerManager.coins + " Coins";

        Time.timeScale = 0;
        finishMenu.SetActive(true);    
    }

    //Quits Application
    public void QuitGame()
    {
        Application.Quit();
    }
}
