using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropboxscrip : MonoBehaviour
{

  MeshRenderer  Renderer ;
  Rigidbody RegidBody;
    [SerializeField] float timeWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
       Renderer = GetComponent<MeshRenderer>(); 
       RegidBody = GetComponent<Rigidbody>();
       Renderer.enabled = false;
       RegidBody.useGravity   = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > timeWait)
        {            
            Renderer.enabled= true;
            RegidBody.useGravity = true;
        }
    }
}
