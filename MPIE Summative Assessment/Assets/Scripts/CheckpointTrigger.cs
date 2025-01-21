using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public PlayerManager playerManager;
    public CanvasManager canvasManager;
    public GameObject checkpoint;

    void OnTriggerEnter() {
        //Checks checkpoint and updates respawn position in Player Manager, and displays confirmation text
        if (checkpoint.name == "Checkpoint 1") {
            playerManager.UpdateCheckpoint(1, checkpoint.transform.position - new Vector3(5.0f, 0.0f, 0.0f));
            canvasManager.DisplayCheckpointText("Checkpoint 1 set");
        }
        else if (checkpoint.name == "Checkpoint 2") {
            playerManager.UpdateCheckpoint(2, checkpoint.transform.position - new Vector3(5.0f, 0.0f, 0.0f));
            canvasManager.DisplayCheckpointText("Checkpoint 2 set");
        }
        else if (checkpoint.name == "Checkpoint 3") {
            playerManager.UpdateCheckpoint(3, checkpoint.transform.position - new Vector3(5.0f, 0.0f, 0.0f));
            canvasManager.DisplayCheckpointText("Checkpoint 3 set");
        }
        else if (checkpoint.name == "Checkpoint 4") {
            playerManager.UpdateCheckpoint(4, checkpoint.transform.position - new Vector3(5.0f, 0.0f, 0.0f));
            canvasManager.DisplayCheckpointText("Checkpoint 4 set");
        }
        else if (checkpoint.name == "Checkpoint 5") {
            playerManager.UpdateCheckpoint(5, checkpoint.transform.position - new Vector3(5.0f, 0.0f, 0.0f));
            canvasManager.DisplayCheckpointText("Checkpoint 5 set");
        }
    }

    void OnTriggerExit() {
        //Resets canvas text
        canvasManager.DisplayCheckpointText("");
    }
}
