using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerVida : MonoBehaviour
{
    [SerializeField] int vidaInicial;
    public int vidaActual;
    public Slider vidaSlider;
    public Image imagenDanyo;
    //public AudioClip muerteClip;
    public float flSpeed = 5f;
    public Color flColor = new Color(1f, 0f, 0f, 0.1f);
    public Text gameOverTXT;
    //Animator anim;
    //AudioSource playerAudio;
    bool estaMuerto;
    bool danyado;


    //anim = GetComponent<Animator>();
    //playerAudio = GetComponent<AudioSource>();
    


    public void Start()
    {
        if (gameOverTXT.isActiveAndEnabled == true)
        {
            gameOverTXT.gameObject.SetActive(false);
        }
        vidaActual = vidaInicial;
        
       
    }


    void Update()
    {
        if (danyado)
        {
            imagenDanyo.color = flColor;
        }
        else
        {
            imagenDanyo.color = Color.Lerp(imagenDanyo.color, Color.clear, flSpeed * Time.deltaTime);
        }
        danyado = false;
    }

    public void EsDanyado (int cuantoDanyo)
    {
        danyado = true;

        vidaActual -= cuantoDanyo;

        vidaSlider.value = vidaActual;

        //playerAudio.Play();

        if(vidaActual <= 0 && !estaMuerto)
        {
            PlayerMuerto();
         
            
        }
    }

    public void PlayerMuerto()
    {
        estaMuerto = true;
        gameOverTXT.gameObject.SetActive(true);
        print("Has Muerto");
        //anim.SetTrigger("HAS MUERTO");

        //playerAudio.clip = muerteClip;
        //playerAudio.Play();

        // PlayerMovement.enabled = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo") == true)
        {
            EsDanyado(25);
            print("pierdes 25 de Vida");


                   

        }


    }

}
