using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI HealthText;
    private GameManager _gm;

    private void Start() 
    {
        _gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    [SerializeField] private int _hits = 1;

    private void OnCollisionEnter(Collision other) 
    {
        _hits--;
        HealthText.text = _hits.ToString();

        if(_hits <= 0)
        {
            _gm.GameOver();
        }
    }
}
