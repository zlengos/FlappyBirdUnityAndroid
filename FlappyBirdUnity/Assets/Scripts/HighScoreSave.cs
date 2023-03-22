using TMPro;
using UnityEngine;

public class HighScoreSave : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highScoreTextSaved;
    
        
        public void Update()
        {
            if (PlayerPrefs.HasKey("highScoreSaved"))
            {
                highScoreTextSaved.text = "HIGHSCORE:" + PlayerPrefs.GetInt("highScoreSaved");
            }
            else
            {
                highScoreTextSaved.text = "HIGHSCORE:0";
            }
        }
    
}
