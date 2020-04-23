﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    //vars
    public string areaToLoad;

    //stores a variable to compare against on exactly where the player exited from the scene
    public string areaTransitionName;

    public AreaEntrance theEntrance;

    // Start is called before the first frame update
    void Start()
    {
        //sets both the entrance and exit variables to one common variable
        theEntrance.transitionName = areaTransitionName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(areaToLoad);

            PlayerController.instance.areaTransitionName = areaTransitionName;
        }
    }

}