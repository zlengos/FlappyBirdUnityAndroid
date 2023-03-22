using TMPro;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; set; }

    [SerializeField] private TextMeshProUGUI scoreText;

   
    private void Start()
    {
        Instance = this;
        SetScore(0);
    }
    private int score;

    public void SetScore(int score)
    {
        this.score += score;
        scoreText.text = "Score:" + this.score;
        
        GameManager.scoresave = this.score;
    }


    
}
