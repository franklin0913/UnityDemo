using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    static PlayerManager Instance;
    public string UserID;

    private void Awake()
    {
        Debug.Log("Test");
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
            SceneManager.LoadScene("LoginScene");
        }
    }
}
