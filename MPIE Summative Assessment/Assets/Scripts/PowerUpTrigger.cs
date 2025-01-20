using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour
{
    public PlayerManager playerManager;

    public GameObject powerUp;

    void OnTriggerEnter() {
        if (powerUp.name == "Jump Power Up") {
            playerManager.hasJumpPowerUp = true;
        }
        if (powerUp.name == "Speed Power Up") {
            playerManager.hasSpeedPowerUp = true;
        }
        if (powerUp.name == "Jump Boost Power Up") {
            playerManager.hasJumpBoostPowerUp = true;
        }

        powerUp.SetActive(false);
    }
}
