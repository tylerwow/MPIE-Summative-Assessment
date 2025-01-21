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
        //Spins object
        t.Rotate(0.0f, 2.0f, 0.0f);
    }
}
