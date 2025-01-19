using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public PlayerManager playerManager;

    public Text livesText;

    public Text coinsText;

    public Text checkpointText;

    void Update()
    {
        livesText.text = playerManager.lives.ToString();
        coinsText.text = playerManager.coins.ToString();
    }

    public void DisplayCheckpointText(string text)
    {
        checkpointText.text = text;
    }
}
