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
    public GameObject effect;
    public GameObject effectPU;
    public GameObject effectChoque;

    //Variable de vida
    
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
    public AudioClip audioExplotion;
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

    //Restricci�n de movimiento
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
            audioSource.PlayOneShot(audioShot, 0.3f);
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
            audioSource.PlayOneShot(audioShot, 0.3f);
        }


    }

    void Start()
    {
       
        Dspeed = 55f;
        meteoritosInst = GameObject.FindWithTag("Meteoritos");


        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        audioSource = GetComponent<AudioSource>();

        SelecionarSpeedNave();
        
        

    }

    void Update()
    {
        //!= si es diferente de
        

        if (GameManager.alive == true)
        {
            MoverNave();
            CheckLimits();
            Disparar();
            StrongDisparo();

        }
        else
        {
            DeadPanel.deadPanel.show();
        }
        print(GameManager.THIS.lifes);


    }

    void MoverNave()
    {

        //Obtengo mi posici�n en X y en Y
        posY = transform.position.y;
        posX = transform.position.x;

        Vector3 movimientoVertical = Vector3.up * Dspeed * Time.deltaTime * movY;
        Vector3 movimientoHorizontal = Vector3.right * Dspeed * Time.deltaTime * movX;

        if (inLimitV)
            transform.Translate(movimientoVertical, Space.World);

        if (inLimitH)
            transform.Translate(movimientoHorizontal, Space.World);


        if (GameManager.naveSelecionada == 0)
        {
     
            //transform.Rotate(Vector3.forward * Time.deltaTime * -360f * rightStickH);
            Vector3 vectorRot = new Vector3(movY * -45f, 0, -45f * movX);
            currentRot = Vector3.SmoothDamp(currentRot, vectorRot, ref velocity, smoothTime);
            transform.eulerAngles = new Vector3(0f, 0f, movX * -60f);


        }
        else if (GameManager.naveSelecionada == 1)
        {



        }
        else if (GameManager.naveSelecionada == 2)
        {
 
            //transform.Rotate(Vector3.forward * Time.deltaTime * -360f * rightStickH);
            Vector3 vectorRot = new Vector3(movY * -45f, 0, -45f * movX);
            currentRot = Vector3.SmoothDamp(currentRot, vectorRot, ref velocity, smoothTime);
            transform.eulerAngles = new Vector3(0f, 0f, movX * -60f);

        }



    }
    void SelecionarSpeedNave()
    {
        if (GameManager.naveSelecionada == 0)
        {
            shipSpeed = 60f;

        }
        else if (GameManager.naveSelecionada == 1)
        {

            shipSpeed = 100f;

        }
        else if (GameManager.naveSelecionada == 2)
        {

            shipSpeed = 65f;

        }
    }

    void CheckLimits()
    {

        //Compruebo l�mites verticales
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

        //Compruebo l�mites horizontales
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


        if (other.gameObject.tag == "Meteoritos")
        {         
            print(shipSpeed);
            if(GameManager.THIS.lifes>0)
            {
                GameManager.THIS.lifes--;
                HudUpdate.THIS.UpdateLifes();
                shipSpeed = shipSpeed / 0.5f;
                Instantiate(effectChoque, transform.position, transform.rotation);
            }
            

            if (GameManager.THIS.lifes <= 0)
            {
                GameManager.alive = false;
                avionMalla.SetActive(false);
                shipSpeed = 0f;
                audioSource.PlayOneShot(audioExplotion, 1f);
                Invoke("Morir", 2f);
                Instantiate(effect, transform.position, transform.rotation);
            }
            else
            {
                Destroy(other.gameObject);

            }

            print(other);
        }
        else if(other.gameObject.tag == "PowerVUp")
        {
            if (GameManager.THIS.lifes <= 2 && GameManager.THIS.lifes >0)
            {
                GameManager.THIS.lifes++;
                HudUpdate.THIS.UpdateLifes();
                //print(shipSpeed);
                shipSpeed = shipSpeed * 1.5f;
                Instantiate(effectPU, transform.position, transform.rotation);
            }
            Destroy(other.gameObject);

        }

    }


    void Morir()
    {

        Time.timeScale = 0;

        DeadPanel.deadPanel.show();
        

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

