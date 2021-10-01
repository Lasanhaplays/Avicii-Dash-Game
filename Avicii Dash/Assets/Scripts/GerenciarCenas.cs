using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciarCenas : MonoBehaviour{
    //Gerenciador de cenas
    public void reiniciarLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void Nivel01() {
        SceneManager.LoadScene("Level_1");
        Time.timeScale = 1f;
    }
    public void Nivel02() {
        SceneManager.LoadScene("Level_2");
        Time.timeScale = 1f;
    }
    public void Nivel03() {
        SceneManager.LoadScene("Level_3");
        Time.timeScale = 1f;
    }
    public void abrirMenu() {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
}
