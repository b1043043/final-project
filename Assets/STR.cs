using UnityEngine;
using TMPro; // �ޤJ TextMeshPro �R�W�Ŷ�

public class STR : MonoBehaviour
{
    private TMP_Text str;

    void Start()
    {
        // �����e����W�� TextMeshPro - Text �ե�
        str = GetComponent<TMP_Text>();
        str.enabled = false; // ���ä�r
    }

    void Update()
    {

    }

    public void showluk()
    {
        str.enabled = true; // ��ܤ�r
    }
}
