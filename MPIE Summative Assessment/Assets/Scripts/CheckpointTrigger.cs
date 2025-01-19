using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public PlayerManager playerManager;
    public CanvasManager canvasManager;
    public GameObject checkpoint;

    void OnTriggerEnter() {
        if (checkpoint.name == "Checkpoint 1") {
            playerManager.UpdateCheckpoint(1, checkpoint.transform.position - new Vector3(5.0f, 0.0f, 0.0f));
            canvasManager.DisplayCheckpointText("Checkpoint 1 set");
        }
        else if (checkpoint.name == "Checkpoint 2") {
            playerManager.UpdateCheckpoint(2, checkpoint.transform.position - new Vector3(5.0f, 0.0f, 0.0f));
            canvasManager.DisplayCheckpointText("Checkpoint 2 set");
        }
    }

    void OnTriggerExit() {
        canvasManager.DisplayCheckpointText("");
    }
}
