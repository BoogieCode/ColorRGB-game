using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {

    public static float speed;
    public GameObject panel;
    public Text text;
    public Text showScore;
    public Text showHighScore;
    float time;
    // Use this for initialization
    void Start () {

        
        speed = 0;


        randomColorChange();
       

    }

    // Update is called once per frame
    void Update () {

       
		transform.position+= Vector3.down * speed * Time.deltaTime;
        if (transform.position.y < -4.7f)
        {
            randomColorChange();
            transform.position = new Vector3(0, 7.3f);
            
        }
        if (speed != 0)
        {
            if (ScoreUp.failed != 2)
            {
                speed = Mathf.SmoothStep(3.5f, 9f, time / 60);
            }
            else
            {
                speed = Mathf.SmoothStep(addsScript.newLifeSpeed, 9f, time / 60);
            }
                 time += Time.deltaTime;
  
        }
  

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (this.gameObject.tag != other.gameObject.tag)
        {

            if (!panel.activeSelf)
            {
                ScoreUp.failed = 1;

                panel.SetActive(true);
                showScore.text="Score: "+ ScoreUp.currentScore;
                showHighScore.text = "HighScore: " + PlayerPrefs.GetInt("highscore");

                addsScript.newLifeSpeed = speed;
                addsScript.newLifeScore = ScoreUp.currentScore;
                speed = 0;
                ScoreUp.currentScore = 0;
            }
            
        }
    }
    public void randomColorChange()
    {
        int randomColor;
        randomColor = Random.Range(1, 4);
        if (randomColor == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            gameObject.tag = "red";
        }
        else if (randomColor == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            gameObject.tag = "green";
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
            gameObject.tag = "blue";
        }
    }


    //void speedUp()
    //{
    //    if (speed != 0)
    //        speed = Mathf.SmoothStep(3.5f, 9f, Time.deltaTime / 60);
    //    //
    //}

    public Image ButtonBackground;
 

}
