using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D birdRigidBody2D;
    [SerializeField] private float jumpForce = 8;

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
    }

    private void BirdJump()
    {
        birdRigidBody2D.velocity = Vector2.up * jumpForce;
        float rotation = birdRigidBody2D.velocity.y * 0.01f;
        if (transform.rotation.z > 0.2f && rotation > 0) rotation = 0;
        else if (transform.rotation.z < -0.2f && rotation < 0) rotation = 0;
        transform.Rotate(0, 0, rotation, Space.Self);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            restartButton.SetActive(true);
            pipeSpawner.SetActive(false);

        }
    }
}
