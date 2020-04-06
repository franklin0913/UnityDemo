using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public Animation _anim;
    private float Timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= 1.5f) _anim.Play("Drop");
        if (Timer >= 4.5f) Destroy(this.gameObject);
    }
}
