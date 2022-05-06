using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
    
{
    public GameObject PlayerMovment;
    public Text CoinText;
    public Text ScoreText;
    public Transform PlayerTransform;
    public int CoinNum;
  

    // Start is called before the first frame update
    void Start()
    {
            CoinNum= PlayerPrefs.GetInt("CoinNum");
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score:" +(Mathf.RoundToInt(PlayerTransform.position.z)*10).ToString();
        CoinText.text = "Coins:" + ((CoinNum)).ToString();
    }
}
