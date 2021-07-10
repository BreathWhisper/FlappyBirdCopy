using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    [SerializeField] private int poolCount = 4;
    [SerializeField] private bool autoExpand = true;
    [SerializeField] private PipeScript pipePrefab;

    private float maxYSpawn = 4f, minYSpawn = -4f;

    private PoolMono<PipeScript> pool;
    private void Start()
    {
        this.pool = new PoolMono<PipeScript>(this.pipePrefab, this.poolCount, this.transform)
        {
            autoExpand = this.autoExpand
        };
    }

    private void OnEnable()
    {
        StartCoroutine(nameof(PipeSpawnerCrt));
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
        float randYSpawnPosition = Random.Range(minYSpawn, maxYSpawn);

        var pipe = this.pool.GetFreeElement();
        pipe.transform.position = new Vector2(5, randYSpawnPosition);
    }
}
