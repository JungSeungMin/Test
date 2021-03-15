using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMng : MonoBehaviour
{

    public Animator CharacterAni;

    float f_Delay=3.0f;

    public Enemy enemy;
    public UiMng uiMng;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        f_Delay -= Time.deltaTime;
    }

    private void FixedUpdate()
    {
        if (f_Delay <= 0)
        {
            CharacterAni.SetTrigger("Attack");
            f_Delay = 3.0f;

            enemy.i_Hp -= uiMng.i_totalPower;

            enemy.t_Hp.text = "Hp : " + enemy.i_Hp;

        }
    }
}
