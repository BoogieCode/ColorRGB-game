using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialScriptPanels : MonoBehaviour {
    public GameObject panel;
    public Text tutorialText;
	// Use this for initialization
	void Start () {
        if (ScoreUp.failed == 2)
        {
            tutorialText.text = "";
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            panel.SetActive(false);
        }
	}
}
