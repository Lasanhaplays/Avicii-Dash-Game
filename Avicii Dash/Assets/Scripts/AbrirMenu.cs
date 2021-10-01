using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirMenu : MonoBehaviour{
    // Define o menu de morte como desligado ao inicar a cena
    void Start(){
        gameObject.SetActive(false);
    }

    //Funcao que liga o menu de morte
    public void LigarMenuMorte() {
        gameObject.SetActive(true);
        StartCoroutine(contadorDeTempo());
    }

    //Pausa o jogo apos 0.9 segundos para haver tempo de exibir a animacao de morte
    private IEnumerator contadorDeTempo() {
        float pausarTempo = Time.realtimeSinceStartup + 0.9f;
        while (Time.realtimeSinceStartup < pausarTempo) yield return 0;
        Time.timeScale = 0f;
    }
}
