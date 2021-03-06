using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    [SerializeField] private float pipeSpeed = 1;
    [SerializeField] private float lifeTime = 3.5f;

    private void OnEnable()
    {
        this.StartCoroutine(nameof(LifeRoutine));
    }

    private void OnDisable()
    {
        this.Deactivate();
    }

    private IEnumerator LifeRoutine()
    {
        yield return new WaitForSecondsRealtime(this.lifeTime);

        this.Deactivate();
    }

    public void Deactivate()
    {
        this.gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.Translate(Vector2.left * pipeSpeed * Time.deltaTime);
    }
}
