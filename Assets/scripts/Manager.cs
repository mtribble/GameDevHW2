using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public static Manager instance;
    public GameObject player;
    public GameObject text;

    public GameObject Ground;
    private Manager(){

    }
    void Awake()
    {
        if(instance)
            Destroy(gameObject);
        else
            instance = this;
    }

    // Update is called once per frame
    void Update()
    {

        if(player.GetComponent<PlayerControls>().health() == 0 && Time.timeScale == 1)
        {
            Debug.Log("game over");
            EndGame();
        }
        else
        {
            Debug.Log("health =" + player.GetComponent<PlayerControls>().health());
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            if(Time.timeScale == 1)
            {
                PauseGame();
            }
            else
            {
                UnPauseGame();
            }
        }
        
        updateScore();
    }

    void updateScore(){
        int curScore = player.GetComponent<PlayerControls>().points;
        int highScore = PlayerPrefs.GetInt("highScore"  ,0);
        text.GetComponent<UnityEngine.UI.Text>().text = "Score: " + curScore;
        if(curScore > highScore)
        {
            Debug.Log("new highscore");
            PlayerPrefs.SetInt("highScore", curScore);
        }
    }

    void EndGame()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Start");

        //doesnt unload first time??
        SceneManager.UnloadScene("GameOver");
        SceneManager.UnloadScene("GameOver");
        
        Time.timeScale = 1;
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
    }

    public void UnPauseGame()
    {
        SceneManager.UnloadSceneAsync("Pause");
        Time.timeScale = 1;
    }
}
