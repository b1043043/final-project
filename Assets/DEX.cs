using UnityEngine;
using TMPro; // �ޤJ TextMeshPro �R�W�Ŷ�

public class DEX : MonoBehaviour
{
    private TMP_Text dex;

    void Start()
    {
        // �����e����W�� TextMeshPro - Text �ե�
        dex = GetComponent<TMP_Text>();
        dex.enabled = false; // ���ä�r
    }

    void Update()
    {

    }

    public void showdex()
    {
        dex.enabled = true; // ��ܤ�r
    }
}
