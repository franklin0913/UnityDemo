using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTarget : MonoBehaviour
{
    private float Timer = 0;
    public GameObject Target;
    private GameObject TargetClone;

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
            float NewX = Random.Range(-6, 6);
            float NewZ = Random.Range(-6, 6);
            TargetClone = Instantiate(Target, new Vector3(NewX, 0, NewZ), Target.transform.rotation);
            Timer = 0;
        }
    }
}
