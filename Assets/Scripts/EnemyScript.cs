using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyScript : MonoBehaviour
{
    public ArrayList Players;

    public PlayerMoveScript PlayerMoveScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag=="Weapon")
        {
            Destroy(gameObject);
        }

        if (collision.transform.tag=="Player")
        {
         PlayerMoveScript.enabled = false;
         PlayerMoveScript.enabled = false;
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
