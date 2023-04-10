using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameManager _gameManager;
    public GameObject YouWonScrene;
    public float jumpForce = 10;
    public float gravityModifier;
    private Rigidbody _playerRB;
    public bool isOnGround = true;
    public float RotationSpeed;

    [SerializeField] private float _moveSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 fowardInput = transform.forward * Input.GetAxis("Vertical");

        _playerRB.AddForce(fowardInput * _moveSpeed, ForceMode.Impulse);
        transform.Rotate(Vector3.up, horizontalInput * RotationSpeed * Time.deltaTime);


         if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            _playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

      
    }

    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
    }

     private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

}
