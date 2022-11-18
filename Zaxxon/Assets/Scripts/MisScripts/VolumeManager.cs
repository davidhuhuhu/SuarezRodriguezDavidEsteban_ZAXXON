using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class VolumeManager : MonoBehaviour
{

    public AudioMixer audioControl;

    //valor del slider
    float sliderValue;
    private static bool created = false;
    AudioSource newAudio;
    float alpha = 1.0f;
    public AudioClip[] PlayList;
    public float fadeSpeed = 2.0f;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
        newAudio = GetComponent<AudioSource>();

        if (!newAudio.playOnAwake)
            newAudio.clip = PlayList[Random.Range(0, PlayList.Length)] as AudioClip;
        newAudio.Play();
        StartCoroutine(Fade());
    }

    void Update()
    {
        if (!GetComponent<AudioSource>().isPlaying)
        {
            playRandomMusic();
            StartCoroutine(Fade());
        }
    }

    public void VolumenMenu(float slidervalue)
    {
        audioControl.SetFloat("MenuVolume", Mathf.Log10(sliderValue) * 20);


    }

    void playRandomMusic()
    {
        GetComponent<AudioSource>().clip = PlayList[Random.Range(0, PlayList.Length)] as AudioClip;
        GetComponent<AudioSource>().Play();


    }
   
    IEnumerator Fade()
    {
        alpha = 0;
        while (alpha < 1f)
        {
            alpha += Time.deltaTime * fadeSpeed;
            yield return null;
        }
        StartCoroutine(FadeOUT());
    }

    IEnumerator FadeOUT()
    {

        yield return new WaitForSeconds(10);
        Debug.Log("FadeOUT");
        while (alpha > 0f)
        {
            alpha -= Time.deltaTime * fadeSpeed;
            yield return null;
        }

    }


}
