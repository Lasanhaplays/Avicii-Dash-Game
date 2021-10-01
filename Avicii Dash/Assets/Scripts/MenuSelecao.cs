using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelecao : MonoBehaviour{
    [SerializeField]
    GameObject botaoPlay;
    void Start(){
        gameObject.SetActive(false);
    }

    public void abrirMenuSelecao() {
        Destroy(botaoPlay);
        gameObject.SetActive(true);
    }
}
