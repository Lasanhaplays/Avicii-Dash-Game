using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxMorteFrente : MonoBehaviour{
    [SerializeField]
    public GameObject DeathPrefab;
    [SerializeField]
    public GameObject Player;
    [SerializeField]
    public GameObject Musica;
    [SerializeField]
    public GameObject MovimentoCamera;
    [SerializeField]
    public GameObject DeathSound;
    public AbrirMenu menuMorte;

    //Hitbox para detectar se o player bateu em algo na frente.
    //Se bateu, é executada a animacao de morte e abre o menu
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Plataforma") {
            Transform posicao = Player.GetComponent<Transform>();
            Instantiate(DeathSound, posicao.position, Quaternion.identity);
            Instantiate(DeathPrefab, posicao.position, Quaternion.identity);
            Destroy(MovimentoCamera.GetComponent<MovimentoCamera>());
            Destroy(Musica);
            Destroy(Player);
            menuMorte.LigarMenuMorte();
        }
    }
}

