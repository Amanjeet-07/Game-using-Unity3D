using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fail_case : MonoBehaviour
{
    hit obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Target").GetComponent<hit>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -165)
        {
            Destroy(gameObject);
            obj.failed();
        }
    }
}
