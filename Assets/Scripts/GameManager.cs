using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool lostGame;

    public PlayerMoveScript PlayerMoveScript;
    public GameObject EndScreen;
    Scene scene;
    public ScoreTextScript CoinNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
    
        if (collision.transform.tag == "Player")
        {
            PlayerMoveScript.enabled = false;
            EndScreen.SetActive(true);
            Invoke("NextLevel", 1.5f);  
        }
    }
        
        
     void NextLevel()
    {
        PlayerPrefs.SetInt("CoinNum", PlayerPrefs.GetInt("CoinNum") + FindObjectOfType<ScoreTextScript>().CoinNum);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        //if (SceneManager.sceneLoaded(0))
        //{

        //}
    }

    public void LostGame()
    {
       // ! before the condintion means false
        if (!lostGame)
        {
            lostGame = true;
            Invoke("ResetGame", 2f);

        }
    }
    void ResetGame()
    {
        PlayerPrefs.SetInt("CoinNum", PlayerPrefs.GetInt("CoinNum") + FindObjectOfType<ScoreTextScript>().CoinNum);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
