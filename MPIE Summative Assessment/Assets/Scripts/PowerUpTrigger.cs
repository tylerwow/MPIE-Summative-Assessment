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

            Console.WriteLine("Jump Power Up Unlocked");
        }
        if (powerUp.name == "Speed Power Up") {
            playerManager.hasSpeedPowerUp = true;

            Console.WriteLine("Speed Power Up Unlocked");
        }

        powerUp.SetActive(false);
    }
}
