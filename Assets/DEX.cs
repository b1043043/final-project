using UnityEngine;
using TMPro; // 引入 TextMeshPro 命名空間

public class DEX : MonoBehaviour
{
    private TMP_Text dex;

    void Start()
    {
        // 獲取當前物件上的 TextMeshPro - Text 組件
        dex = GetComponent<TMP_Text>();
        dex.enabled = false; // 隱藏文字
    }

    void Update()
    {

    }

    public void showdex()
    {
        dex.enabled = true; // 顯示文字
    }
}
