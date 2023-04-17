using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
private void OnCollisionEnter(Collision other) 
{
    if(other.gameObject.CompareTag("Player"))
    {
        GameObject.Find("Player").GetComponent<Player>().ResetPlayerPosition();
    }    
}
}
