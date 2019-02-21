using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUp : MonoBehaviour {

    public Text text;
    public static int currentScore = 1;
    int score;
    public static int failed;
    public Text showScore;
	// Use this for initialization
	void Start () {
        //PlayerPrefs.SetInt("highscore", score);
        InvokeRepeating("ScoreUpping",0f,2f);

    }

    // Update is called once per frame
    void Update()
    {

        if (failed == 1)
        {
            CancelInvoke("ScoreUpping");
            print(currentScore);
            if (currentScore > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore", currentScore);
                //print(PlayerPrefs.GetInt("highscore"));
            }
            failed = 0;
            
        }
    }

    public void ScoreUpping()
    {
           
            text.text = (currentScore++).ToString();
    }
}
