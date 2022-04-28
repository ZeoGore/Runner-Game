using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool lostGame;
    public Scene Level2;
    public PlayerMoveScript PlayerMoveScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
    
        if (collision.transform.tag == "Player")
        {
            PlayerMoveScript.enabled = false;
            Invoke("NextLevel", 1.5f);  
        }
    }
        
        
     void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
