using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScrip : MonoBehaviour
{
    [SerializeField] float xAngel = 0f;
    [SerializeField] float yAngel = 0f;
    [SerializeField] float zAngel = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngel, yAngel, zAngel);
    }
}
