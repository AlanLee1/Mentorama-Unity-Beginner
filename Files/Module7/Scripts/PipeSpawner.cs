using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 4;
    private float timer = 0;
    private float timeGround = 2;
    public GameObject pipe;
    public GameObject ground;

    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(-2.636f, Random.Range(7.2f, 10f), -0.79f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(-2.636f, Random.Range(7.2f, 10f), -0.79f);
            Destroy(newpipe, 15);
            timer = 0;
        }
        if (timer > timeGround)
        {
            ground.SetActive(false);
        }

        timer += Time.deltaTime;
    }
}
