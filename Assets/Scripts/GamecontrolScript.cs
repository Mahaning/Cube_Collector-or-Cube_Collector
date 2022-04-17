using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamecontrolScript : MonoBehaviour
{
    public GameObject start;
    public GameObject Panle;
    public GameObject scrtxt;

    // Start is called before the first frame update
    void Start()
    {
       pause();
       start.SetActive(true);
       Panle.SetActive(false);
       scrtxt.SetActive(false);
    }
    public void gameover()
    {
         Panle.SetActive(true);
         scrtxt.SetActive(false);
    }
    public void restart()
    {
        SceneManager.LoadScene("Game");
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game");
        }
    }
    public void quit()
    {
        Application.Quit();
    }
    public void pause()
    {
         Time.timeScale=0f;
    }
    public void strt()
    {
         Time.timeScale=1f;
         scrtxt.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)||Input.GetKeyDown(KeyCode.Space))
        {
            strt();
            start.SetActive(false);
        }
    }
}
