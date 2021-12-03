using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public SphereCollider sphereCollider;
    public GameObject goldobject;
    PlayerController pcscript;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        pcscript = GameObject.FindGameObjectWithTag("TagA").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Score.ScoreValue += 100;

        player.GetComponent<PlayerController>().ScaleUp();

        Destroy(goldobject);
    }
}
