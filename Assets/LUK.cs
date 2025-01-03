using UnityEngine;
using TMPro; // 引入 TextMeshPro 命名空間

public class LUK : MonoBehaviour
{
    private TMP_Text luk;

    void Start()
    {
        // 獲取當前物件上的 TextMeshPro - Text 組件
        luk = GetComponent<TMP_Text>();
        luk.enabled = false; // 隱藏文字
    }

    void Update()
    {

    }

    public void showluk()
    {
        luk.enabled = true; // 顯示文字
    }
}
