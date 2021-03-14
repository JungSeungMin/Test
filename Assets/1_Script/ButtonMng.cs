using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMng : MonoBehaviour
{
    public GameObject g_QuesltList;
    public GameObject g_CharacterList;

    // Start is called before the first frame update
    void Start()
    {
        
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

}
