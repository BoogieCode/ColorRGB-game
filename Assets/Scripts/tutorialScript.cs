using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialScript : MonoBehaviour {

    CanvasGroup canvas;
    // Use this for initialization
    void Start () {
        canvas = GetComponent<CanvasGroup>();


        canvas.alpha = 0.5f;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            canvas.alpha = 0;

            if (ScoreUp.failed == 0) { 
            
            BarScript.speed = 3.5f;
  
            }
            if(ScoreUp.failed == 2)
            {
            BarScript.speed = addsScript.newLifeSpeed;
            }
        }
        
        // print(addsScript.newLifeSpeed);
    }
}
