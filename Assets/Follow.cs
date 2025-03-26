using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Virus; //define what the object will follow
    public float Dis;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Dis = Vector2.Distance(transform.position, Virus.transform.position);
        //object position, target position

        if (Dis >= 1.2) //prevents the object from overlapping the target
        {
            transform.position = Vector2.MoveTowards(transform.position, Virus.transform.position, 5 * Time.deltaTime);
            //object position, target position, speed
        }

    }
}
