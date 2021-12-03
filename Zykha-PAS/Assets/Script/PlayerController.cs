using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject capsule;
    public Rigidbody rb;
    public float Speed = 10f;

    private float xInput;
    private float zInput;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();

        
       
    }


    private void FixedUpdate()
    {
        Move();
    }
    private void ProcessInput()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        

        
        rb.AddForce(new Vector3(xInput, 0f, zInput) * Speed);

    }

    public void ScaleUp()
    {
        capsule.transform.localScale += (new Vector3(0.25f, 0.25f, 0.25f));
    }



}
