using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float Speed = 10f;
    public float RotationSpeed = 45f;
    public GameObject Bullet;
    public GameObject SpawnPos;

    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnground = true;
    private GameManager _gameManager;
    public GameObject YouWonScrene;
    public GameObject GameOverPanel;
    private Vector3 _startPos;

    private Rigidbody _playerRb;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput =Input.GetAxis("Horizontal");
        Vector3 forwardInput = transform.forward * Input.GetAxis("Vertical");

        _playerRb.AddForce(forwardInput * Speed, ForceMode.Acceleration);
        transform.Rotate(Vector3.up, horizontalInput * RotationSpeed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            Instantiate(Bullet, SpawnPos.transform.position, SpawnPos.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isOnground)
        {
            _playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnground = false;
        }
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isOnground = true;
        }
        else
        {
            if(other.gameObject.CompareTag("Star"))
            {
                YouWonScrene.gameObject.SetActive(true);
            }
        }
    }

    public void ResetPlayerPosition()
        {
            transform.position = _startPos;
        }
}