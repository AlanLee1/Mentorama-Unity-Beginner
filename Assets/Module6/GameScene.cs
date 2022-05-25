using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EntrouScene2()
    {
        SceneManager.LoadScene("Scene2", LoadSceneMode.Additive);
    }

    public void EntrouScene3()
    {
        SceneManager.LoadScene("Scene3", LoadSceneMode.Additive);
        SceneManager.UnloadScene("Scene1");
    }
}
