using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Target;    
    public GameObject Virus; //define what the object will follow
    public float Dis; //distance
    bool isFollowing = false; //following is false
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            Dis = Vector2.Distance(transform.position, Target.transform.position);
            //object position, target position

            if (Dis >= 1.2) //prevents the object from overlapping the target
            {
                transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, 5 * Time.deltaTime);
                //object position, target position, speed
            }
        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal"))
        {
            Virus.GetComponent<Virus>().removeprogramtolist(gameObject);
            Target = collision.gameObject;
            //isFollowing = false; //cease following the player
        }

        if (collision.CompareTag("Player"))
        {
            if (Target == null)
            {
                Target = Virus.GetComponent<Virus>().GetTarget();
            }
           
            Virus.GetComponent<Virus>().addprogramtolist(gameObject);
            isFollowing = true; //follows upon player contact
        }
    }
}
