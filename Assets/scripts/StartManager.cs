using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartManager : MonoBehaviour
{
    public int highScore;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore",0);
        text.GetComponent<UnityEngine.UI.Text>().text = "High Score:" + highScore;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
