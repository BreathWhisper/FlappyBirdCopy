using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D birdRigidBody2D;
    private BirdInput input;

    [SerializeField] private float jumpForce = 8;
    private float maxRotationAngle = 0.4f;
    private float rotationForceModifier = 0.4f;

    public GameObject restartButton;
    public GameObject pipeSpawner;

    private static int score;
    public Text scoreText;

    private void Awake()
    {
        input = new BirdInput();

        input.Bird.Jump.performed += context => BirdJump();
    }

    void Start()
    {
        birdRigidBody2D =  GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        score = 0;
    }
    private void OnEnable()
    {
        input.Enable();
        
    }

    private void OnDisable()
    {
        input.Disable();
    }

    private void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            BirdJump();
        }*/
        float rotationForce = birdRigidBody2D.velocity.y * rotationForceModifier;
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
            this.gameObject.SetActive(false);
            Time.timeScale = 0;
            restartButton.SetActive(true);
            pipeSpawner.SetActive(false);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    public static void ResetScore()
    {
        score = 0;
    }
}
