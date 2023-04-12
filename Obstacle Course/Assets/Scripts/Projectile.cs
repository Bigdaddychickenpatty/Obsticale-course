using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody _targetRb;

    // Start is called before the first frame update
    void Start()
    {
         _targetRb = GetComponent<Rigidbody>();

        _targetRb.AddForce(Vector3.forward, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
