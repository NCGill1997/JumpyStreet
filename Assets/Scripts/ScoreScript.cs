using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{

    public static ScoreScript ScoreKeeper;
    int Score;
    int highScore;

    void Awake()
    {
        if (ScoreKeeper == null)
        {
            DontDestroyOnLoad(gameObject);
            ScoreKeeper = this;
        }
        else if (ScoreKeeper != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }


  

}
