﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public Animator startButton;
    public void StartGame()
    {
        SceneManager.LoadScene("TrainQuestion");
    }
    public void OpenSetting()
    {
        startButton.SetBool("isHidden", false);
    } 
}
