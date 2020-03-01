using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed=0.1f;
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
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            //transform.position = transform.position + Vector3.forward * Speed;
            transform.rotation = new Quaternion(0.1f, 0, 0, 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
            //transform.position = transform.position + Vector3.back * Speed;
            transform.rotation = new Quaternion(-0.1f, 0, 0, 1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
            //transform.position = transform.position + Vector3.right * Speed;
            transform.rotation = new Quaternion(0, 0, -0.1f, 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
            //transform.position = transform.position + Vector3.left * Speed;
            transform.rotation = new Quaternion(0, 0, 0.1f, 1);
        }
    }
}
