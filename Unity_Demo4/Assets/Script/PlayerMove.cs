using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject bullet;
    public GameObject Gun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        else if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime);
        }
        else if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        else if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        else if (Input.GetKeyDown("z"))
        {
            Instantiate(bullet, Gun.transform.position, transform.rotation);
        }
        else if (Input.GetKey("e"))
        {
            transform.Rotate(0, 10, 0);
        }
        else if (Input.GetKey("q"))
        {
            transform.Rotate(0, -10, 0);
        }
    }
}
