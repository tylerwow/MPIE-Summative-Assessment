using UnityEngine;

public class PowerUpTrigger : MonoBehaviour
{
    public PlayerManager playerManager;

    public GameObject powerUp;

    public AudioSource a;

    void OnTriggerEnter() {
        //Adds power up
        if (powerUp.name == "Jump Power Up") {
            playerManager.hasJumpPowerUp = true;
        }
        if (powerUp.name == "Speed Power Up") {
            playerManager.hasSpeedPowerUp = true;
        }
        if (powerUp.name == "Jump Boost Power Up") {
            playerManager.hasJumpBoostPowerUp = true;
        }

        a.Play();

        powerUp.SetActive(false);
    }
}
