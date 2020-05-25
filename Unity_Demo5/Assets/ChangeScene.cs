using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private float Timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= 3)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
