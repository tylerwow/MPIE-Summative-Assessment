using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{
    public PlayerManager playerManager;
    
    void OnTriggerEnter() {
        playerManager.RespawnPlayer();
        playerManager.deaths++;
    }
}
