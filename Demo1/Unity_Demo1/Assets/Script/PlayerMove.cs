using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private readonly float Speed=0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = new Quaternion(0, 0, 0, 1);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + Vector3.forward * Speed;
            transform.rotation = new Quaternion(0.1f, 0, 0, 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + Vector3.back * Speed;
            transform.rotation = new Quaternion(-0.1f, 0, 0, 1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Vector3.right * Speed;
            transform.rotation = new Quaternion(0, 0, -0.1f, 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + Vector3.left * Speed;
            transform.rotation = new Quaternion(0, 0, 0.1f, 1);
        }
    }
}
