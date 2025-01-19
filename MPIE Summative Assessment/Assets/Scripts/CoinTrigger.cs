using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    public GameObject coin;

    public PlayerManager playerManager;

    void OnTriggerEnter() {
        coin.SetActive(false);
        playerManager.coins++;
    }
}