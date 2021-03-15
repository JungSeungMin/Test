using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiMng : MonoBehaviour
{
    public Text t_Gold;
    public Text t_Power;
    public Text t_Stage;


    public int i_totalPower=5;
    public int i_Gold=0;
    public int i_Stage = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t_Gold.text = "Gold : " + i_Gold;
        t_Power.text = "Power : " + i_totalPower;
        t_Stage.text = "Stage : " + i_Stage;
    }
}
