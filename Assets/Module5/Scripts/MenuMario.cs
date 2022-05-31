using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMario : MonoBehaviour
{

    void Start()
    {
        Screen.SetResolution(1920, 1080, true);
    }

    public void CloseApplication()
    {
        //Fechar a aplicação
        Application.Quit();
    }
}
