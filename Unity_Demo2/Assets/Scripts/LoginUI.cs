using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GameData;

public class LoginUI : MonoBehaviour
{
    public Button StartBtn;
    public InputField UseridInput;

    // Start is called before the first frame update
    void Start()
    {
        StartBtn.onClick.AddListener(delegate
        {
            GameApplication.gamedata = new GameFlowData(UseridInput.text);
            Debug.Log(GameApplication.gamedata.UserID);
            SceneManager.LoadScene("Game");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
