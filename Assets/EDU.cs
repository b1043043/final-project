using UnityEngine;
using TMPro; // �ޤJ TextMeshPro �R�W�Ŷ�

public class EDU : MonoBehaviour
{
    private TMP_Text edu;

    void Start()
    {
        // �����e����W�� TextMeshPro - Text �ե�
        edu = GetComponent<TMP_Text>();
        edu.enabled = false; // ���ä�r
    }

    void Update()
    {

    }

    public void showedu()
    {
        edu.enabled = true; // ��ܤ�r
    }
}
