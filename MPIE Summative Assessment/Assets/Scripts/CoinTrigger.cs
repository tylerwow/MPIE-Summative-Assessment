using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    public GameObject coin;

    public AudioSource coinSound;

    public PlayerManager playerManager;

    void OnTriggerEnter() {
        coinSound.Play();
        coin.SetActive(false);
        playerManager.coins++;
    }
}