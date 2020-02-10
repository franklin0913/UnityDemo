using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameData;

public class GameApplication : MonoBehaviour
{
    public static GameFlowData gamedata;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("Login");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
