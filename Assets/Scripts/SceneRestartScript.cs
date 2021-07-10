using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneRestartScript : MonoBehaviour
{
    public GameObject bird;
    public GameObject pipeSpawner;

    public void RestartLevel()
    {   
        bird.transform.position = new Vector3(-1, 0, 10);
        bird.SetActive(true);
        pipeSpawner.SetActive(true);
        Time.timeScale = 1;
        BirdScript.ResetScore();
    }
}
