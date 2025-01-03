using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ControlItem : MonoBehaviour
{
    GameObject name;          // �u���W��
    public string Description;   // �u���y�z
    GameObject player;
    private void Start()
    {
        player = GameObject.Find("player");

    }
    public virtual void st()
    {
        Vector2 p1 = player.transform.position;
        Vector2 p2 = this.transform.position; // �ϥη�e���󪺦�m
        float dist = (p1 - p2).magnitude;

        if ((Input.GetKeyDown(KeyCode.F) | Input.GetKeyDown("f")) & (dist < 1))
        {
            ui(Description);
        }
        else if (dist < 1)
        {
            ui("���");
        }
        
    }
    public virtual void SetDescription(string s)
    {
        Description = s;
    }
    public virtual void ui(string s)
    {
        Debug.Log(s);
        Debug.Log("���}");
    }


}