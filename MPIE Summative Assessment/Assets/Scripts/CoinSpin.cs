using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    Transform t;

    void Start()
    {
        t = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        t.Rotate(0.0f, 2.0f, 0.0f);
    }
}
