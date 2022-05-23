using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject toggle;

    public void CloseApplication(){
        //Fechar a aplicação
        Application.Quit();
    }

    public void SetFullScreen(){
        //Setar o modo de tela
        Screen.fullScreen = toggle.GetComponent<Toggle>().isOn;
    }

    public void SetScreenResolution(){
        //capturar elemento selecionado
        int index = gameObject.GetComponent<Dropdown>().value;
        //verificar o modo de tela
        bool fullScreen = toggle.GetComponent<Toggle>().isOn;
        //setar resolução
        switch(index){
            case 0:
                Debug.Log("0");
                Debug.Log(fullScreen);
                Screen.SetResolution(600, 400, fullScreen);
                break;
            case 1:
                Debug.Log("1");
                Debug.Log(fullScreen);
                Screen.SetResolution(1024, 800, fullScreen);
                break;
            case 2:
                Debug.Log("2");
                Debug.Log(fullScreen);
                Screen.SetResolution(1420, 960, fullScreen);
                break;
            case 3:
                Debug.Log("3");
                Debug.Log(fullScreen);
                Screen.SetResolution(1920, 1080, fullScreen);
                break;
        }
    }


}
