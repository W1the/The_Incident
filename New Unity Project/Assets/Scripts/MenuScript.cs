using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Loads Game Level
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }


    //Quits Game
    public void GameQuit(){
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
