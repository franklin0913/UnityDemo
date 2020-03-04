using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator animator;
    private float h = 0;
    private float v = 0;
    private float prev = 0;
    private Vector3 _forward, _right, preposition;
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
        preposition = transform.position;
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

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isJump_up", true);
            transform.Translate(Vector3.up * Time.deltaTime * 10);
        }

        if (preposition.y == transform.position.y)
        {
            animator.SetBool("isJump_up", false);
        }

        if (prev <= v && v != 0)
        {
            animator.SetBool("isMove", true);
        }
        else
        {
            _speed = 0;
            animator.SetFloat("Speed", _speed);
            animator.SetBool("isMove", false);
        }
        prev = v;
    }

    public void Move()
    {
        Vector3 moveDir = (_forward * v) + (_right * h);//移動方向
        Debug.Log("F:" + _forward + ",R:" + _right);
        Debug.Log(moveDir.normalized);
        if (_speed <= 10)
        {
            transform.Translate(moveDir.normalized * Time.deltaTime * 2, Space.World);
        }
        else
        {
            transform.Translate(moveDir.normalized * Time.deltaTime * 4, Space.World);
        }
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
