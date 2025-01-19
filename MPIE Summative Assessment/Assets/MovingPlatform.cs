using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public Transform waypoint1;

    public Transform waypoint2;

    bool isForward;

    Transform t;

    void Start()
    {
        t = GetComponent<Transform>();

        t.position = waypoint1.position;
        isForward = true;
    }

    void FixedUpdate()
    {
        if (isForward) {
            t.position = Vector3.MoveTowards(t.position, waypoint2.position, speed * Time.deltaTime);
        }
        else {
            t.position = Vector3.MoveTowards(t.position, waypoint1.position, speed * Time.deltaTime);
        }
        
        if (t.position == waypoint1.position) {
            isForward = true;
        }
        else if (t.position == waypoint2.position) {
            isForward = false;
        }
    }
}
