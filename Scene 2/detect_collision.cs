using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class detect_collision : MonoBehaviour
{
    public GameObject UIObject1, UIObject2;
    private int nextScene;

    void start()
    {
        UIObject1.SetActive(false);
        UIObject2.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacles")
        {
            UIObject1.SetActive(true);
            Invoke("restart", 2f);
        }

        else if (collision.gameObject.name == "Finish")
        {
            UIObject2.SetActive(true);
            Invoke("next_scene", 2f);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            Invoke("restart", 2f);
        }       
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void next_scene()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextScene);
    }
}
