using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 2.878555f, -5.5f);

    void LateUpdate()
    {
        //Deslocar a câmera atrás do player adicionando a posição do player
        //posição da camera = posição do player + deslocamento (camera)
        transform.position = player.transform.position + offset;

    }
}
