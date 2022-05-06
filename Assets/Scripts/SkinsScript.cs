using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkinsScript : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Skin1()
    {
        PlayerPrefs.SetInt("SkinNumb",0);
        FindObjectOfType<SkinSelector>().ChooseSkin();
    
    }
    public void Skin2()
    {
       // if (PlayerPrefs.GetInt("CoinsNum") >= 1000)
        //{
            if (PlayerPrefs.GetInt("SkinNum") == 0)
            {
                
                {
                    PlayerPrefs.SetInt("SkinNumb", 1);
                    FindObjectOfType<SkinSelector>().ChooseSkin();
                    PlayerPrefs.SetInt("CoinsNum", PlayerPrefs.GetInt("CoinsNum") - 1000);
                }
            }
            else if (PlayerPrefs.GetInt("SkinNum") == 2)
            {
                
                {
                    PlayerPrefs.SetInt("SkinNumb", 1);
                    FindObjectOfType<SkinSelector>().ChooseSkin();
                    PlayerPrefs.SetInt("CoinsNum", PlayerPrefs.GetInt("CoinsNum") - 1000);
                }
            }
        //}
        
    }
    public void Skin3()
    {
       // if (PlayerPrefs.GetInt("CoinsNum") >= 9999)
       // {
            if (PlayerPrefs.GetInt("SkinNum") == 0)
            {
               
                PlayerPrefs.SetInt("SkinNumb", 2);
                FindObjectOfType<SkinSelector>().ChooseSkin();
                PlayerPrefs.SetInt("CoinsNum", PlayerPrefs.GetInt("CoinsNum") - 9999);
            }
            else if (PlayerPrefs.GetInt("SkinNum") == 1)
            {
               
                PlayerPrefs.SetInt("SkinNumb", 2);
                FindObjectOfType<SkinSelector>().ChooseSkin();
                PlayerPrefs.SetInt("CoinsNum", PlayerPrefs.GetInt("CoinsNum") - 9999);
            }
        }
    //}
}
