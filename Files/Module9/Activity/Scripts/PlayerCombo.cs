using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombo : MonoBehaviour
{
    public Animator animator;
    public int numberClicks = 0;
    public float lastClickedTime = 0f;
    public float delayCombo = 1f;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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

            //don't have any click
            if ((Time.time - lastClickedTime) > delayCombo)
            {
                numberClicks = 0;
                animator.SetBool("combo1", false);
                animator.SetBool("combo2", false);
                animator.SetBool("combo3", false);
                animator.SetBool("combo4", false);
            }

            //Atack
            if (Input.GetMouseButtonDown(0))
            {
                MeleeAttack();
            }
        }
    }

    private void MeleeAttack()
    {
        //Record time of last button click
        lastClickedTime = Time.time;
        numberClicks++;
        if (numberClicks == 1)
        {
            animator.SetBool("combo1", true);
        } else if (numberClicks == 2)
        {
            animator.SetBool("combo2", true);
        } else if (numberClicks == 3)
        {
            animator.SetBool("combo3", true);
        } else if (numberClicks == 4)
        {
            animator.SetBool("combo4", true);
        }

        //limit of clicks between 0 and 4 because have combo for 4 clicks
        numberClicks = Mathf.Clamp(numberClicks, 0, 4);
    }
}
