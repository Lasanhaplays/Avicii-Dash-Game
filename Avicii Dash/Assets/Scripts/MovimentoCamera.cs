using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCamera : MonoBehaviour{
    [SerializeField]
    Transform alvo;
    [SerializeField]
    Vector3 deslocamentoDaCam;
    [SerializeField]
    [Range(0.1f, 1f)]
    float interpolacao = 0.25f;
    Vector3 velocidade = Vector3.zero;

    //Funcao que suaviza o movimento da camera
    void FixedUpdate(){
        Vector3 posicaoFinal = new Vector3 (alvo.position.x + deslocamentoDaCam.x, alvo.position.y + deslocamentoDaCam.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, posicaoFinal, ref velocidade, interpolacao) ;
    }
}
