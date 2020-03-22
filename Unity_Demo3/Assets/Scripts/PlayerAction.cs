using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public Animation _anim;
    private bool _isZaxis = false, _isXaxis = false;
    private int start, end;
    private float _starttime;
    private float lerpvalue;
    public float _speed=1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            _anim.Play("Jump");
            _isZaxis = true;
            _starttime = Time.time;
            start = (int)transform.position.z;
            end = start + 1;
        }
        else if (Input.GetKeyDown("s"))
        {
            _anim.Play("Jump");
            _isZaxis = true;
            _starttime = Time.time;
            start = (int)transform.position.z;
            end = start - 1;
        }
        else if (Input.GetKeyDown("d"))
        {
            _anim.Play("Jump");
            _isXaxis = true;
            _starttime = Time.time;
            start = (int)transform.position.x;
            end = start + 1;
        }
        else if (Input.GetKeyDown("a"))
        {
            _anim.Play("Jump");
            _isXaxis = true;
            _starttime = Time.time;
            start = (int)transform.position.x;
            end = start - 1;
        }
        if (_isZaxis)
        {
            lerpvalue = Mathf.Lerp(start, end, (Time.time - _starttime) * _speed);
            transform.position = new Vector3(transform.position.x, transform.position.y, lerpvalue);
            if (transform.position.z == end) _isZaxis = false;
        }
        if (_isXaxis)
        {
            lerpvalue = Mathf.Lerp(start, end, (Time.time - _starttime) * _speed);
            transform.position = new Vector3(lerpvalue, transform.position.y, transform.position.z);
            if (transform.position.x == end) _isXaxis = false;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Obstacle")
        {
            Debug.Log("撞到障礙物了!!!");
        }
    }
}
