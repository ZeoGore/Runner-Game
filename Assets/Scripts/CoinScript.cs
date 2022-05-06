using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject Scores;
    public ScoreTextScript CoinNum;
    // Start is called before the first frame update

    void Start()
    {
       
    }
   
    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Weapon")
        {
            Scores.GetComponent<ScoreTextScript>().CoinNum++;
            Destroy(gameObject,0.01f);  
        }
        if (collision.transform.tag == "Player")
        {
            Scores.GetComponent<ScoreTextScript>().CoinNum++;
            Destroy(gameObject,0.01f);
        }
    }
 
}
