using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dificuldade : MonoBehaviour
{
    public GameObject dropdown;
    public int dificuldade;

    void Start()
    {
        dificuldade = PlayerPrefs.GetInt("dificuldade", 1);
        //dropdown.GetComponent<Dropdown>().value = dificuldade;
        Debug.Log("INICIOU: " + dificuldade);
    }

    public void setDificuldade()
    {
        dificuldade = dropdown.GetComponent<Dropdown>().value;
        Debug.Log("Alterou: " + dificuldade);

        //salvar um valor no texto dificuldade - cache do pc
        PlayerPrefs.SetInt("dificuldade", dificuldade);

        //Resetar a cena
        SceneManager.LoadScene(SceneManager.GetSceneByName("Module5").name);
    }
}
