using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassScore : MonoBehaviour
{


    /// <summary>
    /// This script may not be needed. For now it is doing things but because PlayerPrefs will be used I might do away with this script as long as everything is working correctly with player prefs.
    /// </summary>

    public static PassScore passScript;
    public int Score;
    public int highScore;

    void Awake()
    {
        if (passScript == null)
        {
            DontDestroyOnLoad(gameObject);
            passScript = this;
        }
        else if (passScript != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }


}
