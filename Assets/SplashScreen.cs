﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen: MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Invoke("LoadFirstScene", 5f);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

