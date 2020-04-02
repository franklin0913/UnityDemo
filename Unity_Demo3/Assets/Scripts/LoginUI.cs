﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginUI : MonoBehaviour
{
    public InputField _Userid;
    public Dropdown _Skin;
    public Button _StartGame;
    public PlayerManager playerManager;

    void Awake()
    {
        Debug.Log("awake");
        playerManager = FindObjectOfType<PlayerManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        _StartGame.onClick.AddListener(StartGame);
        _Skin.onValueChanged.AddListener(SetPlayerSkin);
    }

    void StartGame()
    {
        playerManager.UserID = _Userid.text.ToString();
        SceneManager.LoadScene("GameScene");
    }

    void SetPlayerSkin(int index)
    {
        switch (index)
        {
            case 0:
                playerManager.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.red;
                break;
            case 1:
                playerManager.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.blue;
                break;
        }      
    }
}