using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public PlayerManager playerManager;
    public GameObject checkpoint;

    void OnTriggerEnter() {
        if (checkpoint.name == "Checkpoint 1") {
            playerManager.UpdateCheckpoint(1, checkpoint.transform.position - new Vector3(5.0f, 0.0f, 0.0f));
            Console.WriteLine("Checkpoint set.");
        }
    }
}
