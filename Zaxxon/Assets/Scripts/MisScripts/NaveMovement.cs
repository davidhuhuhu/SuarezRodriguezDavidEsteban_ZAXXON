using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMovement : MonoBehaviour
{
    //Movimiento de la nave

    Vector3 NaveInitPos = Vector3.zero;
    Vector3 NaveMov;

    [SerializeField] GameObject Minave;

    //Variables de posicion y movimiento

    [SerializeField] float movY;
    [SerializeField] float movX;
    [SerializeField] float posY;
    [SerializeField] float posX;
    [SerializeField] float JSLeft;
    

    //Variables de velocidad

    [SerializeField] float movSpeed;




    void Start()
    {
        
        movSpeed = 25f;
        
        transform.position = NaveMov;
        transform.rotation = Quaternion.Euler (0f,0f,0f);
        



    }

    // Update is called once per frame
    void Update()
    {

        //Para que funcionen los ifs siguientes estas variables deben estar declaradas

        posY = transform.position.y;
        posX = transform.position.x;

        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");


        //He metido en el mismo vector los valores de translacion, no se si esta bien pero funciona

        float DirNV = -90;
        float DirNH = -90;


        Vector3 VueloV = new Vector3(0, Input.GetAxis("Vertical"), 0) * movSpeed * Time.deltaTime;
        Vector3 VueloH = new Vector3(0, 0, Input.GetAxis("Horizontal")) * movSpeed * Time.deltaTime;
        Vector3 cambioDV = new Vector3 (0f,DirNV,0f);
        Vector3 cambioDH = new Vector3 (0f,0f,DirNH);


        //En la rotacion le he restado -360 para arreglarla
        Vector3 Rotate = new Vector3(Input.GetAxis("HorizontalRJ"), 0, 0) *-360 * Time.deltaTime;

        /*if ((posY <= 50 || movY < 0) && (posY >= 0 || movY > 0)) */


        //Voy a usar la A y la D porque con las Axis no me deja no se porque

        if (Input.GetKey(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {

            transform.Translate(cambioDV * Time.deltaTime);


        } if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {

            transform.Translate(cambioDH * Time.deltaTime);


        }
        





       /* transform.Translate(VueloV);
        transform.Translate(VueloH);

        transform.Rotate(Rotate);*/










    }
    void MovimientoNave()
    {



    }
}
