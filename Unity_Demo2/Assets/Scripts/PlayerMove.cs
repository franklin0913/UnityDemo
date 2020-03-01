using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator animator;
    public float h = 0;
    public float v = 0;
    private Vector3 _forward, _right;
    private float _speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        _forward = transform.forward;
        _right = transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        
        if (Input.GetKey("d"))
        {
            //h += 0.1f;
            Rotate();
        }
        else if (Input.GetKey("a"))
        {
            //h -= 0.1f;
            Rotate();
        }

        if (Input.GetKey("w"))
        {
            //v += 0.1f;
            _speed += 0.1f;
            animator.SetFloat("Speed", _speed);
            Move();
        }

        if (v >= 0.1f)
        {
            animator.SetBool("isMove", true);
        }
        else
        {
            _speed = 0;
            animator.SetFloat("Speed", _speed);
            animator.SetBool("isMove", false);
        }
    }

    public void Move()
    {
        Vector3 moveDir = (_forward * v) + (_right * h);//移動方向
        transform.Translate(moveDir.normalized * Time.deltaTime * 2, Space.World);
    }

    public void Rotate()
    {
        Vector3 moveDir = (_forward * v) + (_right * h);//移動方向
        Quaternion from = transform.rotation;
        Quaternion to = Quaternion.LookRotation(moveDir.normalized);
        transform.rotation = Quaternion.Lerp(from, to, Time.deltaTime);
        _forward = transform.forward;
        _right = transform.right;
    }
}
