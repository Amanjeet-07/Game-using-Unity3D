using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_color : MonoBehaviour
{
    //main_menu obj;
    public Renderer playerRenderer;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        //obj = GameObject.FindGameObjectWithTag("Menu").GetComponent<main_menu>();
        playerRenderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (main_menu.value == 0)
        {
            color = new Color(0, 0, 1, 0);
        }

        else if (main_menu.value == 1)
        {
            color = new Color(0, 0, 1, 0);
        }

        else if (main_menu.value == 2)
        {
            color = new Color(0, 1, 0, 0);
        }

        else if (main_menu.value == 3)
        {
            color = new Color(1, 1, 0, 0);
        }

        playerRenderer.material.color = color;
    }
}
