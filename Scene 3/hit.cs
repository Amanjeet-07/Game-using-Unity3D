using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hit : MonoBehaviour
{
    public GameObject UIObject1, UIObject2;

    // Start is called before the first frame update
    void Start()
    {
        UIObject1.SetActive(false);
        UIObject2.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Target")
        {
            UIObject2.SetActive(true);
            print("GAME HAS ENDED !");
            Application.Quit();
        }

        else
        {
            failed();
        }    
    }

    public void failed()
    {
        UIObject1.SetActive(true);
        Invoke("restart", 2f);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
