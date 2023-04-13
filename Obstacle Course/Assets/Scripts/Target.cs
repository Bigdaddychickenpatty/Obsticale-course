using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public TextMeshProUGUI Targets;
    public GameObject Star;

    [SerializeField] private int _hits = 1;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);

            _hits--;
            Targets.text = _hits.ToString();

        if(_hits <= 0)
        {
            Star.gameObject.SetActive(true);
        }

        }
    }
}
