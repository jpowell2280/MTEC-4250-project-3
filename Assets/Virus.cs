using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;


public class Virus : MonoBehaviour
{
    public List<GameObject> programs = new List<GameObject>(); //list of game objects

    private Rigidbody2D body; //add a rigid body to the player

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
        //speed will not be dependent on device frame rate
    }
    public void addprogramtolist(GameObject program)
    {
        if (!programs.Contains(program))
        programs.Add(program); //add a program to the list when there are none
    }
    public void removeprogramtolist(GameObject program)
    {
        if (programs.Contains(program))
        programs.Remove(program); //remove a program if one is on the list
    }
    public GameObject GetTarget()
    {
        if (programs.Count == 0) return gameObject; //objects follow in a row
        else return programs[programs.Count - 1]; //else remove the object from the row
    }
}
