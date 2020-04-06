using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public GameObject ground;
    private GameObject _ground;
    private int createpos = 4;
    private float Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= 2)
        {
            _ground = Instantiate(ground, new Vector3(0, 0, createpos), Quaternion.identity);
            createpos += 4;
            Timer = 0;
        }
    }
}
