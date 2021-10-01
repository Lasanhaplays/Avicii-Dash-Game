using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour{
    [SerializeField]
    float velocidadeMaximaX, velocidadeMaximaY, forcaDoPulo;
    [SerializeField]
    public float aceleracao;
    bool puleAgora, esc;
    [SerializeField]
    HitBoxPular hitBox;
    Rigidbody2D rb2d;
    public MenuPause Pause;
   
    void Start(){
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update(){
        puleAgora = Input.GetButton("Jump");
        esc = Input.GetButton("Cancel");

        if (esc) Pause.abrirPause();

        Mover();
        LimiteDeVelocidade();
        if(puleAgora) Pular();
    }

    void Mover(){
        rb2d.AddForce(new Vector2(1 * aceleracao * Time.deltaTime, 0), ForceMode2D.Force);
    }

    void LimiteDeVelocidade(){
        float velocidadeGrampeadaX = Mathf.Clamp(rb2d.velocity.x, -velocidadeMaximaX, velocidadeMaximaX);
        float velocidadeGrampeadaY = Mathf.Clamp(rb2d.velocity.y, -velocidadeMaximaY, velocidadeMaximaY);
        rb2d.velocity = new Vector2(velocidadeGrampeadaX, velocidadeGrampeadaY);
    }
    
    void Pular(){
        if (hitBox.PodePular) rb2d.AddForce(new Vector2(0, forcaDoPulo), ForceMode2D.Impulse);
    }
   
}
