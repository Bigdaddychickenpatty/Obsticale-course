using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public TextMeshProUGUI Targets;
    public GameObject Star;
    public GameObject NextTarget;

    [SerializeField] private int _hits = 0;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);

            NextTarget.gameObject.SetActive(true);

            //_hits--;
            //Targets.text = _hits.ToString();
        }

        else
        {
            if(_hits <= 0)
            {
                Star.gameObject.SetActive(true);
            }
        }

        }
    }
