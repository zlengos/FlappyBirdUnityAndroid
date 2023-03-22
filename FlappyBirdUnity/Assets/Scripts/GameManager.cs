using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using TMPro;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GameObject loseWindow;
    public GameObject Restart;
    public GameObject MainMenu;
    public bool start = false;
    public GameObject playerScript, spawnerScript, scoreScript, alreadyReady, silverMedal, goldMedal;

    [SerializeField] private TextMeshProUGUI scoreAfterLosee, bestScoree;
    public static GameManager instance;
    public static  int scoresave { get; set; }
   

    private void Start()
    {
        instance = this;
    }
    

    public void Lose()
    {
        loseWindow.SetActive(true);
        MainMenu.SetActive(true);
        Restart.SetActive(true);
        Time.timeScale = 0;
        scoreAfterLosee.text = Convert.ToString(scoresave);
        GameManager.instance.SaveHighScore();
        if (scoresave >= 8 && scoresave <= 14)
            silverMedal.SetActive(true);
        else if (scoresave >= 15)
            goldMedal.SetActive(true);
        if (PlayerPrefs.HasKey("highScoreSaved"))
            bestScoree.text = Convert.ToString(PlayerPrefs.GetInt("highScoreSaved"));
        else
            bestScoree.text = "nothing";


    }

    
    public void SaveHighScore()
    {
        if (scoresave > PlayerPrefs.GetInt("highScoreSaved"))
        {
            int highScore = scoresave;
            PlayerPrefs.SetInt("highScoreSaved", highScore);
            Debug.Log("highscore saved");
        }
        else
            Debug.Log("highscore bolshe");
        
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Waiting();
    }
    public void GoToMenu(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
    }
    public void LoadScene(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
        if(SceneNumber == 0)
            Time.timeScale = 1;
        else
        {
            Time.timeScale = 1;
            Waiting();
        }
    }

    // выключаю score, player, spawner
    public void Waiting()
    {
        playerScript.SetActive(false);
        scoreScript.SetActive(false);
        spawnerScript.SetActive(false);
    }
    public void GetReadyAnim()
    {
        alreadyReady.SetActive(false);
        playerScript.SetActive(true);
        scoreScript.SetActive(true);
        spawnerScript.SetActive(true);
        Time.timeScale = 1;
        
    }


    public void Update()
    {
        // ПК клавиши
        //bool play = Input.GetKeyDown(KeyCode.Space);
        //if (loseWindow.activeInHierarchy)
        //{
        //    if (Input.GetKeyDown(KeyCode.Space))
        //        LoadScene(1);

        //    if (Input.GetKeyDown(KeyCode.Escape))
        //        GoToMenu(0);
        //}
        //if (alreadyReady.activeSelf == true)
        //{
        //    if (Input.GetKeyDown(KeyCode.Space))
        //        GetReadyAnim();
        //}
    }
}

