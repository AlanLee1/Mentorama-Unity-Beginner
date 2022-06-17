using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public Animator animator;
    public ParticleSystem particleFire;
    public AudioSource audioPlayer;

    void Start()
    {
        
    }

    void Update()
    {
        if(animator != null)
        {
            animator.SetFloat("speed", 0.0f);
            //Walk
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetFloat("speed", 0.1f);
            }
            //Run
            if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift)){
                animator.SetFloat("speed", 0.6f);
            }
            //Fire
            if (Input.GetMouseButtonDown(0))
            {
                animator.SetTrigger("fire");
            }

        }
    }

    public void PlayVFX()
    {
        particleFire.Stop();
        particleFire.Play();
    }

    public void PlaySound(AudioClip clip)
    {
        audioPlayer.clip = clip;
        audioPlayer.Play();
    }
}
