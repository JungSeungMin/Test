using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMng : MonoBehaviour
{
    public GameObject g_QuesltList;
    public GameObject g_CharacterList;

    public Red red;
    public Green green;

    public UiMng uiMng;

    bool b_green;

    // Start is called before the first frame update
    void Start()
    {
        b_green = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Click_Quset()
    {
        g_CharacterList.SetActive(false);
        g_QuesltList.SetActive(true);
    }
    public void Click_Character()
    {
        g_CharacterList.SetActive(true);
        g_QuesltList.SetActive(false);
    }

    public void RedUpgrade()
    {
        red.i_Level += 1;
        red.i_Power += 5;

        red.t_Level.text = "Lv." + red.i_Level;
        red.t_Power.text = "Power : " + red.i_Power;

        uiMng.i_totalPower += 5;


    }
    public void GreenUpgrade()
    {
        if(!b_green&&uiMng.i_Gold>=100)
        {
            b_green = true;
            green.greenUpgrade.text = "Upgrade";
            green.gameObject.SetActive(true);
            uiMng.i_Gold -= 100;
            uiMng.i_totalPower += 50;
        }
        if (b_green)
        {
            green.i_Level += 1;
            green.i_Power += 50;

            green.t_Level.text = "Lv." + green.i_Level;
            green.t_Power.text = "Power : " + green.i_Power;

            uiMng.i_totalPower += 50;
        }
    }


}
