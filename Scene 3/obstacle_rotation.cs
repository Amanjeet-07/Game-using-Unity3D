using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class obstacle_rotation : MonoBehaviour
{
    public GameObject Obstacle;
    public float angularVelocity = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 Rotation = new Vector3(0, angularVelocity, 0);
        Obstacle.transform.Rotate(Rotation);
    }
}
