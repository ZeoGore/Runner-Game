using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingEnemyScript : MonoBehaviour
{

    public PlayerMoveScript PlayerMoveScript;
    bool Move;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Weapon")
        {
            Destroy(gameObject);
        }

        if (collision.transform.tag == "Player")
        {
            PlayerMoveScript.enabled = false;
            Invoke("ResetGame", 2f);

        }
    }
    private void FixedUpdate()
    {
        if (Move)
        {
            // Moves the object right.
            transform.Translate(2.2f * Time.deltaTime, 0, 0);
            if (transform.position.x >= 2.5f)
            {
                Move = false;
            }
        }
        else
        {
            // Moves the object left.
            transform.Translate(-2.2f * Time.deltaTime, 0, 0);
            if (transform.position.x <= -2.5f)
            {
                Move = true;
            }
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
