using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    private GameObject player;
    public static float Timer;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerManager>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        transform.position = new Vector3(player.transform.position.x, -0.2f, player.transform.position.z);
    }
}
