using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int i_Hp=20;
    public int hp;

    public Text t_Hp;
    public UiMng uiMng;

    // Start is called before the first frame update
    void Start()
    {
        hp = i_Hp;
    }

    // Update is called once per frame
    void Update()
    {

        t_Hp.text = "Hp : " + i_Hp;
    }

    private void FixedUpdate()
    {
        if(i_Hp<=0)
        {
            hp += 5;
            i_Hp = hp;

            uiMng.i_Stage += 1;
            uiMng.i_Gold += 10;
        }
    }
}
