using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombo : MonoBehaviour
{
    public Animator animator;
    public float atackTimer = 0f;
    public float CooldownTimer = 3f;
    public int combo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(tempo);
        if (animator != null)
        {
            animator.SetFloat("speed", 0.0f);
            //Walk
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetFloat("speed", 0.1f);
            }
            //Run
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetFloat("speed", 0.6f);
            }

            MeleeAttack();

            if (Input.GetMouseButtonDown(0))
            {
                animator.SetTrigger("fire");
            }

        }
    }

    private void MeleeAttack()
    {
        if (atackTimer < Time.time && Input.GetMouseButtonDown(1) && combo < 4)
        {
            combo++;
            Debug.Log("Attack " + combo);
            atackTimer = Time.time + CooldownTimer;
        }

        if ((Time.time - atackTimer) > CooldownTimer)
        {
            combo = 0;
            Debug.Log("parado");
        }

        if (combo == 1)
        {
            animator.SetTrigger("combo1");
        }

        if (combo == 2)
        {
            animator.SetTrigger("combo2");
        }

        if (combo == 3)
        {
            animator.SetTrigger("combo3");
        }
    }
}
