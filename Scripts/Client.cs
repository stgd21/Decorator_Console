using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            IRifle rifle = new BasicRifle();
            Debug.Log("Basic accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("s"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(rifle);
            Debug.Log("WithScope accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("t"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithStabilizer(rifle);
            Debug.Log("Stabilizer accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("l"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithLaser(rifle);
            Debug.Log("Laser accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("k"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithStock(rifle);
            Debug.Log("Stock accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("m"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithStock(new WithLaser(new WithStabilizer(new WithScope(rifle))));
            Debug.Log("All accuracy: " + rifle.GetAccuracy());
        }
    }
}
