using UnityEngine;
using TMPro; // �ޤJ TextMeshPro �R�W�Ŷ�

public class INT : MonoBehaviour
{
    public int a = 0; // �p��
    private TMP_Text Int; 

    void Start()
    {
        // �����e����W�� TextMeshPro - Text �ե�
        Int = GetComponent<TMP_Text>();
        Int.enabled = false; // ���ä�r
    }

    void Update()
    {
        
    }

    public virtual void showInt()
    {
        Int.enabled = true; // ��ܤ�r
    }
}
