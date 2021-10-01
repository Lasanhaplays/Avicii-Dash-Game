using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxPular : MonoBehaviour{
    bool podePular;

    //Funcao que retorna se o player pode pular ou nao
    public bool PodePular{
        get { return podePular; }
    }

    //Funcoes que detectam se o player está na plataforma
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "Plataforma") podePular = true;
    }

    private void OnTriggerExit2D(Collider2D collision){
        if (collision.gameObject.tag == "Plataforma") podePular = false;
    }
}
