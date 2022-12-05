using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NaveMovement : MonoBehaviour
{
    //Nave
    public float shipSpeed;
    public NaveMovement naveMovement;
    [SerializeField] GameObject avionMalla;

    //Variable de vida
    bool alive = true;
    public GameObject bullet;
    public GameObject Powerfullbullet;
    public Transform spawnPoint;

    //Balas
    public float bulletForce = 5000f;
    public float StrongBulletForce = 8000f;
    public float bulletRatio = 4f;
    public float StrongBulletRatio = 15f;
    private float shotRateTime = 0;
    private float StrongShotRateTime = 0;
    public AudioClip audioShot;
    AudioSource audioSource;

    //Pos nave y movimiento
    InputActions inputActions;
    [SerializeField] float Dspeed;
    Vector3 navePos = Vector3.zero;
    float movY;
    float movX;
    float rightStickH;
    float shot;
    float StrongShot;
    float n;


    //Script que tiene el Canvas para gestionar el HUD
    //[SerializeField] HudUpdate hudUpdate; 

    //Restricción de movimiento
    float posY;
    float posX;
    float limiteVertUp = 50f;
    float limiteVertDown = -30f;
    float limiteHorRight = 55f;
    float limiteHorLeft = -55f;
    bool inLimitV = true;
    bool inLimitH = true;

    //suavizado de mov
    public float smoothTime = 0.2f;
    private Vector3 velocity = Vector3.zero;
    private Vector3 currentRot;

    //meteoritos
    public GameObject meteoritosInst;

    //Score

    public score newScore;
    


    private void Awake()
    {
        inputActions = new InputActions();

        inputActions.Weapon.Shot.started += _ => Disparar();
        //inputActions.Weapon.StrongShot.started += _ => StrongDisparo();

        inputActions.Weapon.MoveH.performed += ctx => movX = ctx.ReadValue<float>();
        inputActions.Weapon.MoveH.canceled += _ => movX = 0f;

        inputActions.Weapon.MoveV.performed += ctx => movY = ctx.ReadValue<float>();
        inputActions.Weapon.MoveV.canceled += _ => movY = 0f;

        inputActions.Weapon.Shot.performed += ctx => shot = ctx.ReadValue<float>();
        inputActions.Weapon.Shot.canceled += _ => shot = 0f;

        inputActions.Weapon.StrongShot.performed += ctx => StrongShot = ctx.ReadValue<float>();
        inputActions.Weapon.StrongShot.canceled += _ => StrongShot = 0f;

        
        avionMalla.tag = "spaceShip";
        
    }

    void Disparar()
    {

        if (shot > 0)
        {
            if (Time.time > shotRateTime)
            {
                GameObject newBullet;

                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * bulletForce);

                shotRateTime = Time.time + bulletRatio;

                Destroy(newBullet, 2);
                //audioSource.PlayOneShot(audioShot);
            }
        }

    }

    void StrongDisparo()
    {

        if (StrongShot > 0)
        {
            if (Time.time > StrongShotRateTime)
            {
                GameObject newStrongBullet;

                newStrongBullet = Instantiate(Powerfullbullet, spawnPoint.position, spawnPoint.rotation);
                newStrongBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * StrongBulletForce);

                StrongShotRateTime = Time.time + StrongBulletRatio;

                Destroy(newStrongBullet, 2);

            }
        }


    }

    void Start()
    {
        meteoritosInst = GameObject.FindWithTag("Meteoritos");
        Dspeed = 55f;
        

        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //!= si es diferente de

        

       


        if (alive)
        {
            MoverNave();
            CheckLimits();

        }
        else
        {
            DeadPanel.deadPanel.show();
        }

        Disparar();
        StrongDisparo();

    }

    void MoverNave()
    {

        //Obtengo mi posición en X y en Y
        posY = transform.position.y;
        posX = transform.position.x;

        Vector3 movimientoVertical = Vector3.up * Dspeed * Time.deltaTime * movY;
        Vector3 movimientoHorizontal = Vector3.right * Dspeed * Time.deltaTime * movX;

        if (inLimitV)
            transform.Translate(movimientoVertical, Space.World);

        if (inLimitH)
            transform.Translate(movimientoHorizontal, Space.World);


        /*if (CharacterSelection.THIS.navesleccionada == null)

        { 
            CharacterSelection.THIS.navesleccionada = 0;
        }*/

        if (CharacterSelection.THIS.navesleccionada == 0)
        {
            shipSpeed = 60f;
            //transform.Rotate(Vector3.forward * Time.deltaTime * -360f * rightStickH);
            Vector3 vectorRot = new Vector3(movY * -45f, 0, -45f * movX);
            currentRot = Vector3.SmoothDamp(currentRot, vectorRot, ref velocity, smoothTime);
            transform.eulerAngles = new Vector3(0f, 0f, movX * -60f);


        }
        else if (CharacterSelection.THIS.navesleccionada == 1)
        {

            shipSpeed = 80f;
            


        }
        else if(CharacterSelection.THIS.navesleccionada == 2)
        {

            shipSpeed = 65f;
            //transform.Rotate(Vector3.forward * Time.deltaTime * -360f * rightStickH);
            Vector3 vectorRot = new Vector3(movY * -45f, 0, -45f * movX);
            currentRot = Vector3.SmoothDamp(currentRot, vectorRot, ref velocity, smoothTime);
            transform.eulerAngles = new Vector3(0f, 0f, movX * -60f);

        }

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


    private void OnTriggerEnter(Collider other)
    {


        
        /*if(avionMalla)
         {
            hudUpdate.UpdateLifes();
         }
         */

        if (other.gameObject.tag == "PowerVUp")
        {

            shipSpeed++;
            //print(shipSpeed);

        }

        if (other.gameObject.tag == "Meteoritos")
        {
            if(Bulletcol.THIS.impact == true)
            {
                shipSpeed = shipSpeed * 2f;
                
            }

            print(shipSpeed);
            GameManager.THIS.lifes--;
            HudUpdate.THIS.UpdateLifes();

            if (GameManager.THIS.lifes <= 0)
            {
                GameManager.alive = false;
                avionMalla.SetActive(false);
                shipSpeed = 0f;
                Time.timeScale = 0;
                
                DeadPanel.deadPanel.show();
            }
            else
            {
                Destroy(other.gameObject);
            }

            print(other);
        }

    }


    void Morir()
    {

        


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


