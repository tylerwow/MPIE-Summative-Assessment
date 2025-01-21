using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    public GameObject coin;

    public AudioSource coinSound;

    public PlayerManager playerManager;

    void OnTriggerEnter() {
        //Plays coin sound, deactivates coin and adds to coin count
        coinSound.Play();
        coin.SetActive(false);
        playerManager.coins++;
    }
}