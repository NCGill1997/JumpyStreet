using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{

    public int score;
    public int highScore;
   public Text scoreText;
   public Text highScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt("highscore", highScore);
        highScoreText.text = highScore.ToString();
    }

  
    void CaptureHighScore()
    {

        if (score > highScore)
        {
            highScore = score;
            scoreText.text = "Score: " + score;

            PlayerPrefs.SetInt("highscore", highScore);
            highScoreText.text = "HighScore: " + highScore;
        }

    }

}
