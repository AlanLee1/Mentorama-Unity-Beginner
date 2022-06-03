using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jetpack : MonoBehaviour
{
    [SerializeField] public float maxFuel = 2f;
    [SerializeField] private float currentFuel;
    [SerializeField] public float trustForce = 0.1f;
    [SerializeField] public Rigidbody player;
    [SerializeField] public ParticleSystem effect;
    [SerializeField] public Image fuel;

    private void Awake()
    {
        effect.Stop();
    }

    void Start()
    {
        //start to fuel in full
        currentFuel = maxFuel;
        
    }

    // Update is called once per frame
    void Update()
    {        
        //Verifica se esta ativo o jet e se possui combustivel
        //Check if the full is not full and active click
        if (Input.GetAxis("Jump") > 0f && currentFuel > 0f)
        {
            //diminuir o tanque
            currentFuel -= Time.deltaTime;
            //forca pra cima
            player.AddForce(player.transform.up * trustForce, ForceMode.Impulse);
            effect.Play();
            fuel.fillAmount = currentFuel / maxFuel;

            //Physics.Raycast(groundedTransform.position, Vector3.down, 0.05f, LayerMask.GetMask("Grounded"))
        }
        else if (Input.GetAxis("Jump") == 0f && currentFuel < maxFuel)
        {
            currentFuel += Time.deltaTime;
            effect.Stop();
            fuel.fillAmount = currentFuel / maxFuel;
        }
        else
        {
            effect.Stop();
            fuel.fillAmount = currentFuel / maxFuel;
        }
    }
}
