using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public GameObject Player;
  
    public GameObject MainMenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startGame()
    {
        Player.GetComponent<PlayerMoveScript>().enabled = true;
        MainMenu.SetActive(false);
    }

    public void StartLevel1()
    {
        Player.GetComponent<PlayerMoveScript>().enabled = true;
        MainMenu.SetActive(false);
    }
    public void StartLevel2()
    {
        SceneManager.LoadScene(1);
        Player.GetComponent<PlayerMoveScript>().enabled = true;
    }
    public void StartLevel3()
    {
        SceneManager.LoadScene(2);
        Player.GetComponent<PlayerMoveScript>().enabled = true;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
