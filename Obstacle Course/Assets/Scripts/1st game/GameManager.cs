using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject EndScrene;
    public GameObject StartScrene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        EndScrene.gameObject.SetActive(true);
    }

    public void StartButton()
    {
        StartScrene.gameObject.SetActive(false);
    }

    public void ReplayButton()
    {
        SceneManager.LoadScene(0);
    }
}
