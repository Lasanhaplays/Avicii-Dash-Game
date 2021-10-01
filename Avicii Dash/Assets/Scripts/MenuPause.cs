using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour{
    [SerializeField]
    public GameObject Musica, Menu;
    void Start(){
        gameObject.SetActive(false);
    }
    //Despausa o jogo
    public void continuar(){
        Menu.SetActive(false);
        AudioSource music = Musica.GetComponent<AudioSource>();
        music.UnPause();
        Time.timeScale = 1f;
    }
    //Abre o menu de pause
    public void abrirPause(){
        Time.timeScale = 0f;
        AudioSource music = Musica.GetComponent<AudioSource>();
        music.Pause();
        gameObject.SetActive(true);
    }
}
