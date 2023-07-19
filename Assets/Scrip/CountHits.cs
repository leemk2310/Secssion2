using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountHits : MonoBehaviour
{
    int Hits = 0;
    private void OnCollisionEnter(Collision other)
    { 
        if (other.gameObject.tag != "HIT")
        {
            Hits++;
            Debug.Log("Count Hit Number "  + Hits);
        }
    }
}
