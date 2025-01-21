using UnityEngine;

public class FollowParent : MonoBehaviour
{
    public GameObject parent;
    Transform t;

    void Update() {
        //Transform follows parent object
        t = gameObject.transform;
        t.position = parent.transform.position;
    }
}
