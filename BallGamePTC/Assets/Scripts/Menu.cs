using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame()
    {
        SceneManager.LoadScene("HTP");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void THTP()
    {
        SceneManager.LoadScene("Pick");
    }

    public void L1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void L2()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void L3()
    {
        SceneManager.LoadScene("Scene2");
    }

}
