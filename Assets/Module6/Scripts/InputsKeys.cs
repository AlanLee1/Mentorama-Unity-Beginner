using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputsKeys : MonoBehaviour
{
    [SerializeField] public float forca = 150f;
    [SerializeField] public float velocidadeMaxima = 10f;

    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, verticalInput * forca * Time.deltaTime));
        GetComponent<Rigidbody>().AddForce(new Vector3(horizontalInput * forca * Time.deltaTime, 0, 0));

    }

    void OnCollisionEnter(Collision collision)
    {
        //Colisão com a rampa1
        if(collision.collider.name == "Cube")
        {
            if (!SceneManager.GetSceneByName("Scene2").isLoaded)
            {
                SceneManager.LoadScene("Scene2", LoadSceneMode.Additive);
            }
            
        //Colisão com a rampa2
        }else if(collision.collider.name == "Cube (2)"){
            //A cena esta ativa?
            if (SceneManager.GetSceneByName("Scene1").isLoaded)
            {
                SceneManager.LoadScene("Scene3", LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync("Scene1");
            }
        }
    }
}
