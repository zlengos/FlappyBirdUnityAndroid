using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppQuit : MonoBehaviour
{
   
    void Update()
    {
        // ПК кнопки
        //if (Input.GetKey("escape"))
        //    QuitFromGame();
        //if (Input.GetKey("space"))
        //    StartGame();
    }

    public void QuitFromGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        GameManager.instance.LoadScene(1);

    }
}
