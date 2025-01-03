using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public INT intScript;
    public ControllCamera A;

    public float speed = 5f;
    public float x;          
    public float y;
    public int e;
    void Start()
    {
        intScript = FindObjectOfType<INT>();
        A = FindObjectOfType<ControllCamera>();
        e = 0;
    }
    void Update()
    {
        float step = 1f;
        // 移動邏輯
        if (x <14.5f & y<44 & x>-119.5f & y>-33)
        {
            if (Input.GetKey(KeyCode.W) | Input.GetKeyDown("w"))
            {
                y = y + 0.01f;
            }
            if (Input.GetKey(KeyCode.S) | Input.GetKeyDown("s"))
            {
                y = y - 0.01f;
            }
            if (Input.GetKey(KeyCode.D) | Input.GetKeyDown("d"))
            {
                x = x + 0.01f;
            }
            if (Input.GetKey(KeyCode.A) | Input.GetKeyDown("a"))
            {
                x = x - 0.01f;
            }
            if (y < 4.5f & y > -4.5f & x < 12.5f & x > -12)
            {
                if (e != 1)
                {
                    A.b(0f, 0f);
                    this.transform.position = new Vector2(0f, 0f);
                    e = 1;
                }
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(x, y), step);
            }
            else if (x > -10 & x < 14 & y < -14.5f & y > -31)
            {
                if (e != 2)
                {
                    A.b(2.5f, -26.5f);
                    x = 2.5f;
                    y = -26.5f;
                    e = 2;
                }
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(x, y), step);
            }
            else if (x > -71 & x < -47 & y < 6 & y > -11)
            {
                if (e != 3)
                {
                    A.b(-60.5f, -6f);
                    x = -60.5f;
                    y = -6f;
                    e = 3;
                }
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(x, y), step);
            }
            else if (x > -53 & x < -28.5f & y < 43 & y > 27)
            {
                if (e != 4)
                {
                    A.b(-43.5f, 30.5f);
                    x = -43.5f;
                    y = 30.5f;
                    e = 4;
                }
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(x, y), step);
            }
            else if (x > -71 & x < -58 & y < 44 & y > 34.5f)
            {
                if (e != 5)
                {
                    A.b(-64f, 36f);
                    x = -64f;
                    y = 36f;
                    e = 5;
                }
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(x, y), step);
            }
            else if (x > -119 & x < -95 & y < 16 & y > 0)
            {
                if (e != 6)
                {
                    A.b(-107f, 2f);
                    x = -107f;
                    y = 2f;
                    e = 6;
                }
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(x, y), step);
            }
            else if (x > -119.5f & x < -95 & y < -1.8f & y > -18.5f)
            {
                if (e != 7)
                {
                    A.b(-107f, -14f);
                    x = -107f;
                    y = -14f;
                    e = 7;
                }
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(x, y), step);
            }
            else if (x > -119 & x < -95 & y < -21.5f & y > -33.5f)
            {
                if (e != 8)
                {
                    A.b(-108f, -31.5f);
                    x = -109f;
                    y = -30;
                    e = 8;
                }
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(x, y), step);
            }
            else
            {
                e = 0;
                A.a();
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(x, y), step);
            }
        }
        else
        {
            x -= 0.01f;
            y -= 0.01f;
        }
        

        
        //互動
        if(Input.GetKeyDown(KeyCode.F) | Input.GetKeyDown("f"))
        {
            Debug.Log("f");
        }

        // 背包檢視
        if (Input.GetKeyDown(KeyCode.B) | Input.GetKeyDown("b"))
        {
            FindObjectOfType<PlayerInventory>().ShowInventory();
        }
        
    }
}


