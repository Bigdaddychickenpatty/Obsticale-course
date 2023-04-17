using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastTarget : MonoBehaviour
{
    public GameObject Star;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);

            Star.gameObject.SetActive(true);
        }
    }
}
