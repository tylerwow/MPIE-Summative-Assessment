using UnityEngine;

public class FollowParent : MonoBehaviour
{
    public GameObject parent;
    Transform t;

    void Update() {
        t = gameObject.transform;

        t.position = parent.transform.position;
    }
}
