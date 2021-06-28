using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipes;
    void Start()
    {
        StartCoroutine("PipeSpawner");
    }

    /*private void OnDisable()
    {
        StopCoroutine("PipeSpawner");
    }*/
    void Update()
    {

    }

    IEnumerator PipeSpawner()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(2);
            float rand = Random.Range(-4f, 4);

            GameObject pipe = Instantiate(pipes, new Vector2(5, rand), Quaternion.identity);
            Destroy(pipe, 8);

        }
    }
}
