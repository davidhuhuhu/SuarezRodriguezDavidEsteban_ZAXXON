using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{

    [SerializeField] Transform nave;

    [SerializeField] float offsetZ;
    [SerializeField] float offsetY;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(nave);

        Vector3 targetPosition = nave.position - new Vector3(0f, -offsetY, offsetZ);
        transform.position = targetPosition;

    }
}
