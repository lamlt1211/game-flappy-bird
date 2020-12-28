﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class HighscoreText : MonoBehaviour
{
    Text highscore;
    // ham tinh diem
    void Start()
    {
        highscore = GetComponent<Text>();
        highscore.text = "High Score:" + PlayerPrefs.GetInt("HigtScore").ToString();
    }
}
