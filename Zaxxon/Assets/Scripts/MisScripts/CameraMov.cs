using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    [SerializeField] Transform target;
  
    [SerializeField] Vector3 offset;

    
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posint = target.position + offset;



        transform.position = posint;
        transform.LookAt(target);

    }
}
