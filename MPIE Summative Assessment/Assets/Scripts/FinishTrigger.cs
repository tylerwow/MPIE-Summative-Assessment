using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public CanvasManager canvasManager;

    void OnTriggerEnter() {
        canvasManager.DisplayFinishMenu();
    }
}
