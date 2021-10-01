using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxDano : MonoBehaviour{
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

    //Hitbox para detectar qualquer objeto que cause dano ao player
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Dano") {
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
