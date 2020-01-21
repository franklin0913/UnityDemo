﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Start : MonoBehaviour
{
    public Button StartBtn;

    // Start is called before the first frame update
    void Start()
    {
        StartBtn.onClick.AddListener(delegate 
        {
            SceneManager.LoadScene("GameScene");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
