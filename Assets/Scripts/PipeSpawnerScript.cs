using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    [SerializeField] private int poolCount = 4;
    [SerializeField] private bool autoExpand = true;
    [SerializeField] private PipeScript pipePrefab;
    //public GameObject pipes;

    private PoolMono<PipeScript> pool;
    void Start()
    {
        this.pool = new PoolMono<PipeScript>(this.pipePrefab, this.poolCount, this.transform)
        {
            autoExpand = this.autoExpand
        };
        StartCoroutine("PipeSpawnerCrt");
    }

    /*private void OnDisable()
    {
        StopCoroutine("PipeSpawner");
    }*/
    void Update()
    {

    }

    IEnumerator PipeSpawnerCrt()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(2);

            PipeSpawn();
        }
    }

    private void PipeSpawn()
    {
        float rand = Random.Range(-4f, 4);

        var pipe = this.pool.GetFreeElement();
        pipe.transform.position = new Vector2(5, rand);
        //GameObject pipe = Instantiate(pipes, new Vector2(5, rand), Quaternion.identity);
        //Destroy(pipe, 8);
    }
}
