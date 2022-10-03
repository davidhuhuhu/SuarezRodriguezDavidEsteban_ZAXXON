using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMovement : MonoBehaviour
{

    public float speed;
    [SerializeField] NaveMovement naveMovement;
    //Variable de vida
    bool alive = true;


    //Pos nave
    Vector3 navePos = Vector3.zero;

    //Velocidad de desplazamientio
    [SerializeField] float Dspeed;

    //Variables de Input
    float movY;
    float movX;

    float rightStickH;

    Vector2 move;

    InputActions inputActions;

    //Restricción de movimiento
    float posY;
    float posX;
    float limiteVertUp = 10f;
    float limiteVertDown = 0f;
    float limiteHorRight = 10f;
    float limiteHorLeft = -10f;

    bool inLimitV = true;
    bool inLimitH = true;


    private void Awake()
    {
        inputActions = new InputActions();

        inputActions.Weapon.Shot.started += _ => Disparar();

        //inputActions.Player.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        //inputActions.Player.Move.canceled += _ => move = Vector2.zero;

        inputActions.Weapon.MoveH.performed += ctx => movX = ctx.ReadValue<float>();
        inputActions.Weapon.MoveH.canceled += _ => movX = 0f;

        inputActions.Weapon.MoveV.performed += ctx => movY = ctx.ReadValue<float>();
        inputActions.Weapon.MoveV.canceled += _ => movY = 0f;

    }

    void Disparar()
    {
        print("Bimbam");
    }


    // Start is called before the first frame update
    void Start()
    {
        Dspeed = 20f;


        //Inicio en 9 de posición y de rotación
        //transform.position = navePos;
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    /*
    private void FixedUpdate()
    {
        navePos += despl;
        transform.position = navePos * desplSpeed * Time.deltaTime;
    }
    */

    // Update is called once per frame
    void Update()
    {

        //print(move);


        if (alive)
        {
            MoverNave();
            CheckLimits();
        }


    }

    void MoverNave()
    {


        //print(moveX);
        //Obtengo mi posición en X y en Y
        posY = transform.position.y;
        posX = transform.position.x;

       


        Vector3 movimientoVertical = Vector3.up * Dspeed * Time.deltaTime * movY;
        Vector3 movimientoHorizontal = Vector3.right * Dspeed * Time.deltaTime * movX;

        if (inLimitV)
            transform.Translate(movimientoVertical, Space.World);

        if (inLimitH)
            transform.Translate(movimientoHorizontal, Space.World);


        transform.Rotate(Vector3.forward * Time.deltaTime * -360f * rightStickH);

        //transform.eulerAngles = new Vector3(0f, 0f, moveX * -60f);

    }

    void CheckLimits()
    {

        //Compruebo límites verticales
        if (posY > limiteVertUp && movY > 0)
        {
            inLimitV = false;
        }
        else if (posY < limiteVertDown && movY < 0)
        {
            inLimitV = false;
        }
        else
        {
            inLimitV = true;
        }

        //Compruebo límites horizontales
        if (posX > limiteHorRight && movX > 0)
        {
            inLimitH = false;
        }
        else if (posX < limiteHorLeft && movX < 0)
        {
            inLimitH = false;
        }
        else
        {
            inLimitH = true;
        }


    }


    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

}


