using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{

    public GameObject naveTarget;
    //[SerializeField] Transform navesTarget;

    [SerializeField] float offsetZ;
    [SerializeField] float offsetY;
    [SerializeField] public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update

    private void Awake()
    {
        naveTarget = GameObject.FindWithTag("spaceShip");

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(nave);

        //Vector3 targetPosition = naveTarget.transform.position - new Vector3(0f, -offsetY, offsetZ);
        // va lentito
        //transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        if (naveTarget == null)
        {
            naveTarget = GameObject.FindWithTag("spaceShip");
        }
        else
        {
            Vector3 targetPosition = naveTarget.transform.position - new Vector3(0f, -offsetY, offsetZ);
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);


        }



        /*  [SerializeField] Transform target;

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

        }*/
    }
}
