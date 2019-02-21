using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Character : MonoBehaviour {

	// Use this for initialization
	void Start () {
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

    // Update is called once per frame
   // public float speed = 100f;

    void Update()
    {
      

        
    }
   

    public void changeColorLeft()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
        gameObject.tag = "green";
    }
    public void changeColorRight()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        gameObject.tag = "red";
    }
    public void changeColorBlue()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
        gameObject.tag = "blue";
    }

}

