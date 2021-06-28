using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    [SerializeField] private float pipeSpeed = 1;
    void Update()
    {
        transform.Translate(Vector2.left * pipeSpeed * Time.deltaTime);
    }
}
