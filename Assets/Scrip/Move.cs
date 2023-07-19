using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float moveSpeed = 10f;
    [SerializeField] float yValue = 0;
    [SerializeField] float mainthrust = 600f;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // set move button 
        MovePlayer();
        ProcessPush();
    }
    void PrintInstruction ()
    {
        Debug.Log("don't hit the wall");
        Debug.Log("Move the ball with arrow Key");
    }

    void MovePlayer()
    {
        float xvalue =  Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed ;
         float zValue =  Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed ;
        transform.Translate(xvalue, yValue, zValue);
    }

    void ProcessPush()
    {
        //set key to push
        // set value up, with verctor 2(2d), vector3 (3d)
       if( Input.GetKey(KeyCode.Space))
         { 
            rb.AddRelativeForce(Vector3.up * mainthrust * Time.deltaTime); 
            Debug.Log("câccacacac");
            // if (!audioSource.isPlaying)
            //  {
            //     audioSource.PlayOneShot(Flysound);
                
            //  } 
            //  //set particle to action
            //  if (!MainParticle.isPlaying)
            //  {
            //    MainParticle.Play();
            //  }
        }
        // else 
        // {
        //     audioSource.Stop();
        //     MainParticle.Stop();
        // }
    }
}
