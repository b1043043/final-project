using UnityEngine;
using TMPro; // �ޤJ TextMeshPro �R�W�Ŷ�

public class WIL : MonoBehaviour
{
    private TMP_Text wil;

    void Start()
    {
        // �����e����W�� TextMeshPro - Text �ե�
        wil = GetComponent<TMP_Text>();
        wil.enabled = false; // ���ä�r
    }

    void Update()
    {

    }

    public void showwil()
    {
        wil.enabled = true; // ��ܤ�r
    }
}
