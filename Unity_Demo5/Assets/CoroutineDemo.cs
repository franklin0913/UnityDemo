﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineDemo : MonoBehaviour
{
    public ParticleSystem system;
    public GameObject ball;
    private GameObject temp = null;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Game());
        Print();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            if (temp != null)
            {
                Destroy(temp);
            }
            temp=Instantiate(ball);
            timer = 0;
        }
    }

    IEnumerator Game()
    {
        yield return new WaitForSeconds(5);
        system.Play();
        yield return new WaitUntil(() => Move._change);
        system.startColor = new Color(255, 0, 0);
        Debug.Log("END");
        yield return null;
    }

    void Print()
    {
        Debug.Log("到這裡啦~~");
        for(int i=0;i<10; i++)
        {
            Debug.Log(i);
        }
    }
}
