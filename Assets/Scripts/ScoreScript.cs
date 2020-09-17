using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{

    public static ScoreScript ScoreKeeper;

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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



}
