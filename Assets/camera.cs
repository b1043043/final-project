using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllCamera : MonoBehaviour
{
    public float speed = 5f; // �t��
    private float x = 0f;
    private float y = 0f;

    void Start()
    {
    }

    public virtual void  a()
    {
        float step = 1f;

        // �����޿�
        if (Input.GetKey(KeyCode.W))
        {
            y += 0.01f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            y -= 0.01f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            x += 0.01f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            x -= 0.01f;
        }

        // �T�O�۾���m�b�C�ӴV���|��s�A�O�� Z �b�� -10
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(x, y, -10), step);
    }
    public virtual void b(float x1,float y1)
    {
        x = x1;
        y = y1;
        this.transform.position = new Vector3(x, y, -10);
    }
    }
