using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFinal : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        gameObject.SetActive(false);
    }

    //Abre o menu quando o jogador chega non final do mapa
    public void LigarMenuFinal() {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
}
