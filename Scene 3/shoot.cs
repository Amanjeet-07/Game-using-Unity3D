using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public GameObject torpedo;
    public Transform shooter;
    private Vector3 startPos;
    private float currentLerpTime = 0;
    public float LerpTime = 5;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            torpedo = Instantiate(torpedo, shooter.position, shooter.rotation) as GameObject;
            startPos = torpedo.transform.position;

            currentLerpTime += Time.deltaTime;
            if (currentLerpTime >= LerpTime)
                currentLerpTime = LerpTime;
            float perc = currentLerpTime / LerpTime;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                torpedo.transform.position = Vector3.Lerp(startPos, hit.point, perc);
            }
        }
    }
}

