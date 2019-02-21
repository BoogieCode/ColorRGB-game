using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;



public class nextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void next()
    {
        ScoreUp.failed = 0;
        SceneManager.LoadScene(1);
    }
    public void quit()
    {
        Application.Quit();
        

    }
}
