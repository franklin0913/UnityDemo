using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public AudioSource BGM;
    public static bool _change = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 2);
        }
        else if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 2);
        }
        else if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 2);
        }
        else if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 2);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            BGM.Play();
        }
        if (Input.GetKeyDown("z"))
        {
            _change = true;
        }
    }
}
