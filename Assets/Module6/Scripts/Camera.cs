using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 2.878555f, -5.5f);

    void LateUpdate()
    {
        //Deslocar a c�mera atr�s do player adicionando a posi��o do player
        //posi��o da camera = posi��o do player + deslocamento (camera)
        transform.position = player.transform.position + offset;

    }
}
