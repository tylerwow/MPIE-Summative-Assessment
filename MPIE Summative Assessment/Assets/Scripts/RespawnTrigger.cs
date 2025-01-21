using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{
    public PlayerManager playerManager;
    
    void OnTriggerEnter() {
        //Respawns player
        playerManager.RespawnPlayer();
    }
}
