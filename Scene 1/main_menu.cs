 using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    private int nextScene;
    public static int value;
    
    public void play()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextScene);
    }

    public void color(int val)
    {
        value = val;
    }

    public void quit()
    {
        print("GAME HAS ENDED !");
        Application.Quit();
    }
}
