using UnityEngine;

public class ControlSea : MonoBehaviour
{
    public GameObject player;      // ���a����
    public float interactDistance = 1f; // ���ʶZ��
    public int like;
    public virtual void Start()
    {
        player = GameObject.Find("player");
        like = Random.Range(1, 100);
    }

    public virtual void Update()
    {
        if (player == null)
        {
            player = GameObject.Find("player");
        }

        Vector2 p1 = player.transform.position;
        Vector2 p2 = transform.position;
        float dist = (p1 - p2).magnitude;

        if (Input.GetKeyDown(KeyCode.F) && dist < interactDistance)
        {
            TriggerInteraction();
        }
    }

    // ������k�Ѥl���O��{
    public virtual void TriggerInteraction()
    {
        if (like <= 90)
        {
            like += 10;
        }
        Debug.Log(like);
    }
}
