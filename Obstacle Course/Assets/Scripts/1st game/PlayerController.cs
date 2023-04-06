using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager _gameManager;
    public GameObject YouWonScrene;

    [SerializeField] private float _moveSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
            _gameManager.GameOver();
        }
        else
        {
            if(other.gameObject.CompareTag("Flag"))
            {
                YouWonScrene.gameObject.SetActive(true);
            }
        }
    }
}
