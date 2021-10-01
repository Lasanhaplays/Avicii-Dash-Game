using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinal : MonoBehaviour{
    public MenuFinal menu;

    private void OnTriggerEnter2D(Collider2D collision) {
        menu.LigarMenuFinal();
    }
}
