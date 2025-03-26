using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Virus : MonoBehaviour
{
    private Rigidbody2D body;

    float horizontal; //horizontal movement
    float vertical; //vertical movement

    public float runSpeed = 20.0f; //speed

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>(); //declare body
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); //movement input 
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector3(horizontal * runSpeed * Time.deltaTime, vertical * runSpeed * Time.deltaTime); 
        //not dependent on device frame rate
    }
}
