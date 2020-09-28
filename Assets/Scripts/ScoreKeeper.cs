using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{

    public static ScoreKeeper ScoreScript;
    public int score;
    public int highScore;
    public Text scoreText;
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreScript = this;
        score = 0;
        highScore = PlayerPrefs.GetInt("highscore", highScore);
        highScoreText.text = "HighScore: " + highScore;
    }


    void CaptureHighScore()
    {

        if (score > highScore)
        {

            highScore = score;
            scoreText.text = "Score: " + score;
            PlayerPrefs.SetInt("highscore", highScore);
            
        }

    }


   public void AddScore()
   {

        score++;
        scoreText.text = "Score " + score;
        CaptureHighScore();
        highScoreText.text = "HighScore: " + highScore;

   }



void PassScoreToSingleton()
    {

        PassScore.passScript.Score = score;
        PassScore.passScript.highScore = highScore;
    }




}
