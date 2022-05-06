using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSelector : MonoBehaviour
{

    public Material Purple;
    public Material Blue;
    public Material Black;
    public PlayerMoveScript moveScript;

    // Start is called before the first frame update
    void Start()
    {
        ChooseSkin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseSkin()
    {
       
        if (PlayerPrefs.GetInt("SkinNumb")==0)
        {
            GetComponent<MeshRenderer>().material= Purple;
            GetComponent<PlayerMoveScript>().forwardSpeed = 600;
            GetComponent<PlayerMoveScript>().sideSpeed = 350;

        }
        else if (PlayerPrefs.GetInt("SkinNumb") == 1)
        {
            GetComponent<MeshRenderer>().material =Blue;
            GetComponent<PlayerMoveScript>().forwardSpeed = 700;
            GetComponent<PlayerMoveScript>().sideSpeed = 350;
            PlayerPrefs.SetInt("CoinsNum", PlayerPrefs.GetInt("CoinsNum") - 1000);
        }
       else  if (PlayerPrefs.GetInt("SkinNumb") == 2)
        {
            GetComponent<MeshRenderer>().material = Black;
            GetComponent<PlayerMoveScript>().forwardSpeed = 600;
            GetComponent<PlayerMoveScript>().sideSpeed = 400;
            PlayerPrefs.SetInt("CoinsNum", PlayerPrefs.GetInt("CoinsNum") - 9999);
        }
    }
}
