using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D birdRigidBody2D;
    [SerializeField] private float jumpForce = 8;
    private float maxRotationAngle = 0.4f;

    public GameObject restartButton;
    public GameObject pipeSpawner;

    void Start()
    {
        birdRigidBody2D =  GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BirdJump();
        }
        float rotationForce = birdRigidBody2D.velocity.y * 0.4f;
        if (transform.rotation.z > maxRotationAngle && rotationForce > 0) rotationForce = 0;
        else if (transform.rotation.z < -maxRotationAngle && rotationForce < 0) rotationForce = 0;
        transform.Rotate(0, 0, rotationForce, Space.Self);
    }

    private void BirdJump()
    {
        birdRigidBody2D.velocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            restartButton.SetActive(true);
            pipeSpawner.SetActive(false);

        }
    }
}
