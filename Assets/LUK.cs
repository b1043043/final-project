using UnityEngine;
using TMPro; // �ޤJ TextMeshPro �R�W�Ŷ�

public class LUK : MonoBehaviour
{
    private TMP_Text luk;

    void Start()
    {
        // �����e����W�� TextMeshPro - Text �ե�
        luk = GetComponent<TMP_Text>();
        luk.enabled = false; // ���ä�r
    }

    void Update()
    {

    }

    public void showluk()
    {
        luk.enabled = true; // ��ܤ�r
    }
}
