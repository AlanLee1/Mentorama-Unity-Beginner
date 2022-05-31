using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCenas : MonoBehaviour
{
    void funcao()
    {

        //carrega cena por nome
        SceneManager.LoadScene("Scene1");
        //carrega cena por index
        SceneManager.LoadScene(1);
        //carrega cena em pararelo por index/nome
        SceneManager.LoadSceneAsync(1);
        //carrega cena e remove a cena anterior
        SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
        //carrega cena e continua com a cena anterior
        SceneManager.LoadScene("Scene1", LoadSceneMode.Additive);
        //Quando esta utilizando uma cena de forma additive e quer excluir a anterior
        //SceneManager.UnloadScene("Scene1");
        //Recarregar a cena
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
